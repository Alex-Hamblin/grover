using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float shootForce;

    private float _trueDamage;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void Init(float chargePercent, Vector3 fireDirection)
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(shootForce * chargePercent * fireDirection, ForceMode.Impulse);
        _trueDamage = chargePercent * damage;
    }

    private void OnCollisionEnter(Collision other)
    {
        print(other.transform.name +", " + other.transform.root.name);

        if(other.transform.root.TryGetComponent(out IDamagable hitTarget))
        {
            switch(other.transform.tag)
            {

                case "Head":
                    _trueDamage *= 2;
                    break;
                case "Limb":
                    _trueDamage *= 0.8f;
                    break;
                
             


            }

            print("has taken damage" + _trueDamage);
            hitTarget.TakeDamage(_trueDamage);
        }
       
        Destroy(gameObject);
    }
}
