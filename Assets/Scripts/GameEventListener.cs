using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class GameEventListener : MonoBehaviour, IListener
{
    [TextArea] public string Notes;

    public GameEvent GameEvent;
    public GameEventResponse Response;

    public GameObject SenderObject;

    public void OnEnable()
    {
        Subscribe();
    }
    
    public void Subscribe()
    {
        GameEvent.AddListener(this);
    }

    public void Unsubscribe()
    {
        GameEvent.RemoveListener(this);
    }

    public void OnEventRaised(params Object[] args)
    {
        //var sender = args[0];
        //var other = args[1];
        
        //if its null we will call it
        if (SenderObject == null)
        {
            Response.Invoke(args);
        }
        else
        {
        }
    }

    public void OnDisable()
    {
        Unsubscribe();
    }

    public void OnEventRaised()
    {
        OnEventRaised(null);
    }
}
