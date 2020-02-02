using System.Collections;
using System.Collections.Generic;
using RhythmTool;
using UnityEngine;

public class EnemyGridTraversalBehaviour : MonoBehaviour
{

    public GameObject currentGridSpace;
    private GridNode gridNode;
    
    public RhythmEventProvider eventProvider;
    
    void Start()
    {
        eventProvider.Register<Beat>(TraverseLogic);
        gridNode = currentGridSpace.GetComponent<GridNode>();
    }


    void Update()
    {
        
    }

    public void TraverseLogic(Beat beat)
    {
        List<GridNode> neighbors = new List<GridNode>();
        if (gridNode.BottomNeighbor != null && (gridNode.BottomNeighbor.isOccupied == false))
            neighbors.Add(gridNode.BottomNeighbor);
        
        if (gridNode.TopNeighbor != null && (gridNode.TopNeighbor.isOccupied == false))
            neighbors.Add(gridNode.TopNeighbor);
        
        if (gridNode.RightNeighbor != null && (gridNode.RightNeighbor.isOccupied == false))
            neighbors.Add(gridNode.RightNeighbor);
        
        if (gridNode.LeftNeighbor != null && (gridNode.LeftNeighbor.isOccupied == false))
            neighbors.Add(gridNode.LeftNeighbor);

        var rand = new System.Random();
        var index = rand.Next(neighbors.Capacity);
        
        gridNode.isOccupied = false;
        gridNode = neighbors[index];
        gridNode.isOccupied = true;
        
        transform.position = gridNode.sitPosition;
    }
}
 