using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    public void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + theScore; 
    }
}
