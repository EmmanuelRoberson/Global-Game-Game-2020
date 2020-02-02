using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public float _health = 100f;
    public float _maxHealth = 100f;

    private bool isAlive = true;

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

    private void OnCollisionEnter(Collision other)
    {
        //if(other.gameObject.CompareTag("ground"))
        //{
        //    Debug.Log("Scollision have been made");
        //}
        
    }


    public void Update()
    {
       
       
    }

}
