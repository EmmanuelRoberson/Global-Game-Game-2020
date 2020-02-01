using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Serialization;

public class GridCreateBehaviour : MonoBehaviour
{
    public GameObject startObject;
    public int GridDimensionZ;
    public int GridDimensionX;

    public float GapSize;
    
    List<List<GridNode>> allNodesGrid = new List<List<GridNode>>();

    public float timeBetweenInstantiation = 0;
    
    private bool isGridCreated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (!isGridCreated)
        {
           CreateGrid();
        }
    }

    private void CreateGrid()
    {
        for (int j = 0; j < GridDimensionZ; j++)
        {
            allNodesGrid[j] = new List<GridNode>();
            for (int i = 0; i < GridDimensionX; i++)
            {
                allNodesGrid[j][i] = new GridNode();
            }
        }
        
        for (int j = 0; j < GridDimensionZ; j++)
        {
            for (int i = 0; i < GridDimensionX; i++)
            {
                if (j == 0 && i == 0)
                {
                    allNodesGrid[j][i].nodeObject.transform.position = startObject.transform.position;
                }
                else
                {
                    allNodesGrid[j][i].nodeObject.transform.position =
                        startObject.transform.position + new Vector3(
                            startObject.transform.position.x + i * GapSize,
                            startObject.transform.position.y,
                            startObject.transform.position.z + j * GapSize);
                }
            }
        }
        
        for (int j = 0; j < GridDimensionZ; j++)
        {
            for (int i = 0; i < GridDimensionX; i++)
            {
                                                    //if at the top
                allNodesGrid[j][i].TopNeighbor = (j == (GridDimensionZ - 1)) 
                    ? null :
                    allNodesGrid[j + 1][i];
                                                    //if at the bottom
                allNodesGrid[j][i].BottomNeighbor = (j == 0)
                    ? null
                    : allNodesGrid[j - 1][i];
                                                    //if at the left side
                allNodesGrid[j][i].LeftNeighbor = (i == 0) 
                    ? null 
                    : allNodesGrid[j][i + 1];
                                                    //if at the right side
                allNodesGrid[j][i].RightNeighbor = (i == (GridDimensionX - 1))
                    ? null
                    : allNodesGrid[j][i + 1];
            }
        }
        

        isGridCreated = true;
    }
}
