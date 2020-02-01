using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventListener : MonoBehaviour, IListener
{
    [TextArea] public string Notes;

    public GameEvent GameEvent;
    public GameEventResponse Response;

    public GameObject SenderObject;
    
    public void Suscribe()
    {
        throw new System.NotImplementedException();
    }

    public void Unsibscribe()
    {
        throw new System.NotImplementedException();
    }

    public void OnEventRaised(params Object[] obj)
    {
        throw new System.NotImplementedException();
    }

    public void OnEventRaised()
    {
        throw new System.NotImplementedException();
    }
}
