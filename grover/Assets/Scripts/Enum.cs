using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Enum : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI Health;
    [SerializeField] private TextMeshProUGUI Shield;
    [SerializeField] private TextMeshProUGUI Point;
    public float _totalHealth;
    public float _totalShield;
    public float _totalPoint;
    public enum EProjectileType
    {
        point,
        boost,
        health,
      
        
    }
    [SerializeField] EProjectileType _type;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void tagged()
    {
        if (_type == EProjectileType.health)
        {
            _totalHealth ++;
            Health.text = _totalHealth.ToString();
        }
        if (_type == EProjectileType.boost)
        {
            if (_totalShield <=49)
            {
                _totalShield++;
            }
            
            Shield.text = _totalShield.ToString();
        }
        if (_type == EProjectileType.point)
        {
            _totalPoint++;
            Point.text = _totalPoint.ToString();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            tagged();
        }
    }
}

