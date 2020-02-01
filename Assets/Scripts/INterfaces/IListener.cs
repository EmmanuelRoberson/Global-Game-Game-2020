using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IListener
{
    void Suscribe();
    void Unsibscribe();
    void OnEventRaised(params Object[] obj);
    void OnEventRaised();
}
