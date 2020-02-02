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
        timeBetweenBeats = (1 /beatsPerSecond) - beatOffset;
        audio.loop = true;
        audio.Play();
        endedToleranceEvent = true;
    }

    // Update is called once per frame
    void Update()
    {
        ToleranceBeatChecker();
        OnBeatChecker();
        timeBetweenBeats += Time.fixedDeltaTime;

        //timeBetweenBeats comes out at around when logged 0.4472928f;
    }

    void OnBeatChecker()
    {
        if (timeBetweenBeats >=  (1 /beatsPerSecond) - beatOffset)
        {
            //Debug.Log(timeBetweenBeats);
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
                Debug.Log("began tolerance");
                beganToleranceEvent = true;
                endedToleranceEvent = false;
            }
        }

        if (beganToleranceEvent)
        {
            if (timeBetweenBeats >= ((1 / beatsPerSecond) - beatOffset) + inputTolerance)
            {
                endToleranceEvent.Raise();
                Debug.Log("ended tolerance");
                beganToleranceEvent = false;
                endedToleranceEvent = true;
            }
        }
    }
}
