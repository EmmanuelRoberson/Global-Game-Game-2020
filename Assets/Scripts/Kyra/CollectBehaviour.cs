using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sphere"))
        {
            Destroy(other.gameObject);
        }

    }
}
