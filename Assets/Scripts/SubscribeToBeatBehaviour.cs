using RhythmTool;
using UnityEngine;

public class SubscribeToBeatBehaviour : MonoBehaviour
{
    public RhythmEventProvider eventProvider;
    
    // Start is called before the first frame update
    void Start()
    {
        //Register the OnBeat method to the event provider
        eventProvider.Register<Beat>(OnBeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBeat(Beat beat)
    {
        Debug.Log("A beat occureed at " + beat.timestamp);
    }
}
