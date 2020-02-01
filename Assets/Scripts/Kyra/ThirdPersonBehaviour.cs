using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonBehaviour : MonoBehaviour
{
    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private const float _Y_Angle_Min = 0.0f;
    private const float _Y_Angle_Max = 50.0f;

    private float _distance = 10.0f;
    private float _currentX = 0.0f;
    private float _currentY = 0.0f;
    private float _sensivityX = 4.0f;
    private float _sensivityY = 1.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        _currentX += Input.GetAxis("Mouse X");
        _currentY -= Input.GetAxis("Mouse Y");

        _currentY = Mathf.Clamp(_currentY, _Y_Angle_Min, _Y_Angle_Max);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -_distance);
        Quaternion rotation = Quaternion.Euler(_currentY, _currentX, 0.0f);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
