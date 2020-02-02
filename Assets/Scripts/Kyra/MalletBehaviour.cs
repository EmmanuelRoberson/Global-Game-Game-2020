using RhythmTool;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MalletBehaviour : MonoBehaviour
{
    public RhythmEventProvider hh;

    private void Start()
    {
        hh.Register<Beat>(OnBeat);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeat(Beat beat)
    {
        /*
        if (transform.rotation.x <= 0)
        {
            transform.Rotate(, 90f);
            
            //transform.SetPositionAndRotation(transform.position,
              //  new UnityEngine.Quaternion(90,transform.rotation.y,transform.rotation.z ,transform.rotation.w));
        }
        else if (transform.rotation.x >= 85)
        {
            transform.Rotate(Vector3.right, -90f);
            //transform.SetPositionAndRotation(transform.position,
               // new UnityEngine.Quaternion(0, transform.rotation.y, transform.rotation.z, transform.rotation.w));
        }
        */
        
        transform.Rotate(Vector3.right,90f);

    }


}
