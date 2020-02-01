using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonBehaviour : MonoBehaviour
{
    

    public Transform playerTransform;

    private Vector3 _camreaOffset;

    [Range(0.1f, 1.0f)]

    public float smoothFactor = 0.5f;

    public bool lookAt = false;

    private void Start()
    {
        _camreaOffset = transform.position - playerTransform.position;
    }

    private void LateUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 newPos = playerTransform.position + _camreaOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
        Vector3 camRotation = new Vector3(hor, 0, ver) * Time.deltaTime;
        transform.Rotate(camRotation, Space.Self);
        if (lookAt)
        {
            transform.LookAt(playerTransform);
        }
    }
}
