using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IListener
{
    void Subscribe();
    void Unsubscribe();
    void OnEventRaised(params Object[] obj);
    void OnEventRaised();
}
