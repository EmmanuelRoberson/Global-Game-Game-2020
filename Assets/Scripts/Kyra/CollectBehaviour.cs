using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sphere"))
        {
            ItemBehaviour.theScore += 10;
            Destroy(other.gameObject);
        }

    }
}
