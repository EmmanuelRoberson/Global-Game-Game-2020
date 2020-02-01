using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatTimerBehaviour : MonoBehaviour
{
    [SerializeField] private float beatsPerMinute;

    private float beatsPerSecond;

    [SerializeField] private GameEvent onBeatEvent;

    private float timeBetweenBeats;


    // Start is called before the first frame update
    void Start()
    {
        beatsPerSecond = beatsPerMinute / 60;
        timeBetweenBeats = 0;
    }

    // Update is called once per frame
    void Update()
    {
        OnBeatChecker();
        timeBetweenBeats += Time.smoothDeltaTime;
    }

    void OnBeatChecker()
    {
        if (timeBetweenBeats >= (1 / beatsPerSecond))
        {
            onBeatEvent.Raise();
            Debug.Log("Beat Raised Called");
            timeBetweenBeats = 0;
        }
    }
}
