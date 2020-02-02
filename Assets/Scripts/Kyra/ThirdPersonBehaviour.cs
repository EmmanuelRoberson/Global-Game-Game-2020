using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonBehaviour : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    void Start()
    {
        //offset = transform.position - target.transform.position;
        transform.position = target.transform.position + offset;
    }

    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
