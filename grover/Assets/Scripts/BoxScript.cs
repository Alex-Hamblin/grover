using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour, IDamagable
{
    [field: SerializeField] public float Health { get; set; }
    [SerializeField] private float speed;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rb.AddForce(Vector3.forward * speed);

        Vector3 velocity = _rb.velocity;

        float currentSpeed = _rb.velocity.magnitude;
        if(currentSpeed > 5)
        {
            Vector3 normalized = _rb.velocity / currentSpeed;
            _rb.velocity = normalized * 5;
        }
       

        
    }

    public void Die()
    {
        Destroy(gameObject);
    }
    

}
