using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovementBehaviour : MonoBehaviour
{

    public float speed;

    public void Update()
    {

    }

    public void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0, ver);
        transform.Translate(playerMovement, Space.Self);
    }
}
