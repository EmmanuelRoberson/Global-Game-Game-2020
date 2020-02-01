using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class BeatTimerBehaviour : MonoBehaviour
{
    [SerializeField] private float beatsPerMinute;

    private float beatsPerSecond;

    [SerializeField] private GameEvent onBeatEvent;
    [SerializeField] private GameEvent beginToleranceEvent;
    [SerializeField] private GameEvent endToleranceEvent;
        
    private bool beganToleranceEvent;
    private bool endedToleranceEvent;

    private float timeBetweenBeats;

    [SerializeField] private AudioSource audio;

    public float beatOffset;
    public float inputTolerance;

    // Start is called before the first frame update
    void Start()
    {
        beatsPerSecond = beatsPerMinute / 60;
        timeBetweenBeats = 0;
        audio.loop = true;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        OnBeatChecker();
        timeBetweenBeats += Time.smoothDeltaTime;
    }

    void OnBeatChecker()
    {
        if (timeBetweenBeats >=  (1 /beatsPerSecond) - beatOffset)
        {
            Debug.Log(timeBetweenBeats);
            onBeatEvent.Raise();
            timeBetweenBeats = 0;
        }
        
        //audio.timeSamples/audio.clip.frequency
        //beats per second - 0 +  the input tolerance, which should be set in the inspector
    }

    void ToleranceBeatChecker()
    {
        if (endedToleranceEvent)
        {
            if (timeBetweenBeats >= ((1 / beatsPerSecond) - beatOffset) - inputTolerance)
            {
                beginToleranceEvent.Raise();
                beganToleranceEvent = true;
                endedToleranceEvent = false;
            }
        }

        if (beganToleranceEvent)
        {
            if (timeBetweenBeats >= ((1 / beatsPerSecond) - beatOffset) + inputTolerance)
            {
                endToleranceEvent.Raise();
                beganToleranceEvent = false;
                endedToleranceEvent = true;
            }
        }
    }
}
