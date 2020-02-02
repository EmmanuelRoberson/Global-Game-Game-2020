using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Vector3 = UnityEngine.Vector3;

public class UICountDownBehaviour : MonoBehaviour
{
    public TextMeshPro text;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountDown3()
    {
        text.text = "3";
    }
    
    public void CountDown2()
    {
        text.text = "2";
    }
    
    public void CountDown1()
    {
        text.text = "1";
    }

    public void HideMe()
    {
        //
    }
}
