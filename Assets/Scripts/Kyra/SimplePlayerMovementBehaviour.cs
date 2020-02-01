using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovementBehaviour : MonoBehaviour
{

    public float speed;

    public void Update()
    {
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.D);


        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(hor, 0, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (Input.GetKey(KeyCode.R))
        {
            
            transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * -speed);
        }
    }

}
