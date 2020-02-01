using System.Collections;
using System.Collections.Generic;
using System.Data;
using INterfaces;
using UnityEngine;

public class MaterialColorChangerBehaviour : MonoBehaviour, IReactable
{
    public string colorChangeMethod;
    
    public List<Material> materials;
    public List<Color> colorChoices;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void React()
    {

        var rand = new System.Random();

        foreach (var material in materials)
        {
            material.color = colorChoices[rand.Next(0,colorChoices.Count)];
        }
    }
}
