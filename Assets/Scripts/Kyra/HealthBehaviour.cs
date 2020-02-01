using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public HealthBehaviour target;

    public float _health = 100f;
    public float _maxHealth = 100f;
    
    public float damage = 20f;

    public void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            Fight();
        }
    }

    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            if (_health > _maxHealth)
            {
                _health = _maxHealth;
            }
            else if (_health < 0)
            {
                _health = 0;
            }
        }

    }

    public void Fight()
    {
        if (Health <= 0)
        {
            return;
        }

        target.Health -= damage;        
    }

    
}
