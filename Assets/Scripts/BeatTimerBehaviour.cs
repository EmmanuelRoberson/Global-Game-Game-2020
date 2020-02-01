using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatTimerBehaviour : MonoBehaviour
{
    [SerializeField] private float beatsPerMinute;

    private float beatsPerSecond;

    [SerializeField] private GameEvent onBeatEvent;

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
        timeBetweenBeats += Time.deltaTime;
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
}
