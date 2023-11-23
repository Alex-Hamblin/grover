using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;


public abstract class WeaponBase : MonoBehaviour
{
    [Header("Weapon base stats")]
    [SerializeField] protected float timeBetweenAttacks;
    [SerializeField] protected float chargeupTime;
    [SerializeField, Range(0, 1)] protected float minChargePercent;
    [SerializeField] private bool isFullyAuto;


    private Coroutine _currentFireTimer;
    private WaitForSeconds _cooldownWait;

    private WaitUntil _cooldownEnforce;
    private bool _isOnCooldown;
    private float _currentChargeTime;


    private void Start()
    {
        _cooldownWait = new WaitForSeconds(timeBetweenAttacks);
        _cooldownEnforce = new WaitUntil(() => !_isOnCooldown);
    }


    public void StartShooting()
    {
        _currentFireTimer = StartCoroutine(RefireTimer());
    }
    public void StopShooting()
    {
        StopCoroutine(_currentFireTimer);

        float percent = _currentChargeTime / chargeupTime;
        if (percent != 0) TryAttack(percent);
    }


    private IEnumerator CoolDownTimer()
    {
        _isOnCooldown = true;
        yield return _cooldownWait;
        _isOnCooldown = false;
    }
    private IEnumerator RefireTimer()
    {
        print("waiting for cooldown");
        yield return _cooldownEnforce;
        print("post cooldown");
        yield return null;

        while (_currentChargeTime < chargeupTime)
        {
            _currentChargeTime += Time.deltaTime;
            yield return null;
        }
        TryAttack(1);
        yield return null;

    }

    private void TryAttack(float percent)
    {
        _currentChargeTime = 0;
        if (!CanAttack(percent)) return;

        Attack(percent);
        StartCoroutine(CoolDownTimer());


        if (isFullyAuto && percent >= 1) _currentFireTimer = StartCoroutine(RefireTimer()); //Auto refire


    }
    protected virtual bool CanAttack(float percent)
    {
        return !_isOnCooldown && percent >= minChargePercent;
        
    }
    protected abstract void Attack(float percent);

  
}
