using System.Collections;
using System.Collections.Generic;
using RhythmTool;
using UnityEngine;

public class EnemyGridTraversalBehaviour : MonoBehaviour
{

    public GameObject currentGridSpace;
    private GridNode gridNode;
    
    public RhythmEventProvider EventProvider;
    
    void Start()
    {
        EventProvider.Register<Beat>(TraverseLogic);
    }


    void Update()
    {
        
    }
    
    public void GetTopNeighbor()
    {
        transform.position = gridNode.TopNeighbor.sitPosition;
        gridNode = gridNode.TopNeighbor;
    }
    
    public void GetBottomNeighbor()
    {
        transform.position = gridNode.BottomNeighbor.sitPosition;
        gridNode = gridNode.BottomNeighbor;
    }
    
    public void GetLeftNeighbor()
    {
        transform.position = gridNode.LeftNeighbor.sitPosition;
        gridNode = gridNode.LeftNeighbor;
    }
    
    public void GetRightNeighbor()
    {
        transform.position = gridNode.RightNeighbor.sitPosition;
        gridNode = gridNode.RightNeighbor;
    }

    public void TraverseLogic(Beat beat)
    {
        
    }
}
