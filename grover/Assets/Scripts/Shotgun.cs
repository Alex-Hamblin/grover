using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shotgun : WeaponBase
{
    [SerializeField] private Projectile myBullet;
   
    [SerializeField] private float force = 50;
    [SerializeField] private float force2 = 50;
    [SerializeField] public float _Ammo;
    [SerializeField] public float _maxAmmo;
    [SerializeField] public float _totalAmmo;
    [SerializeField] public float _shotsFired;
    [SerializeField] private TextMeshProUGUI shotsFired;
    [SerializeField] private TextMeshProUGUI totalAmmo;
    [SerializeField] private TextMeshProUGUI damage;
    [SerializeField] private TextMeshProUGUI bulletSpeed;
    [SerializeField] private TextMeshProUGUI weapon;
    [SerializeField] public float _damage;
    [SerializeField] public float _bulletSpeed;
    [SerializeField] public string _weapon;
    protected override void Attack(float percent)
    {
        if (_Ammo >= 1 && _totalAmmo >= 0)
        {
            print("my weapon attacks" + percent);
            Ray camRay = InputManager.GetCameraRay();
            _Ammo--;
            _shotsFired++;
            Projectile rb = Instantiate(myBullet, camRay.origin, transform.rotation);
         
            rb.Init(percent, camRay.direction);
           
            
        }
    }
    private void FixedUpdate()
    {
        shotsFired.text = _Ammo.ToString();
        totalAmmo.text = _totalAmmo.ToString();
        damage.text = _damage.ToString();
        bulletSpeed.text = _bulletSpeed.ToString();
        weapon.text = _weapon.ToString();
    }
    internal void Reload()
    {
        _totalAmmo -= _shotsFired;
        if (_Ammo <= 29)
        {
            _Ammo = _maxAmmo;
        }
        else if (_Ammo > 30)
        {
            _Ammo = _maxAmmo;
        }

        _shotsFired = 0;



    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }


}