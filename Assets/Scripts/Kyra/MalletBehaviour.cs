using RhythmTool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (transform.rotation.x >= 0)
        {
            transform.SetPositionAndRotation(transform.position, new UnityEngine.Quaternion(90,0,0,0));
        }
        if (transform.rotation.x == 90)
        {
            transform.SetPositionAndRotation(transform.position, new UnityEngine.Quaternion(0, 0, 0, 0));
        }

    }

}
