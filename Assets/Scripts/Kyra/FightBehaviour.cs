using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBehaviour : MonoBehaviour
{
    public HealthBehaviour player;

    public float damage = 200f;

    private bool isAlive = true;

    public void Fight(Collider col)
    {
        if (player.Health <= 0)
        {
            return;
        }

        player.Health -= damage;
    }

    private void OnCollisionEnter(Collision other)
    {
       // Debug.Log("collision have been made");
        
        if (player.Health >= 0)
        {
            player.Health -= damage;
            
        }
        
    }

    public void StillAlive()
    {
        if (player.Health == 0)
        {
            isAlive = false;
        }

        if (isAlive == false)
        {
            Destroy(gameObject);
            Debug.Log("");
        }
    }

    public void Update()
    {
        StillAlive();
    }
}
