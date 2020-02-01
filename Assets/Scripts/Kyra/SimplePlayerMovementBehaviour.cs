using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovementBehaviour : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1), Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1), Space.Self);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0), Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0), Space.Self);
        }
    }

}
