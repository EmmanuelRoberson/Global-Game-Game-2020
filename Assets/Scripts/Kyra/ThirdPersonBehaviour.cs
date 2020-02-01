using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonBehaviour : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1), Space.Self);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(-1, 0, 0), Space.Self);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(1, 0, 0), Space.Self);
        }
    }
}
