using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTraversalBehaviour : MonoBehaviour
{
    public GameObject currentGridSpace;
    private GridNode gridNode;
    private float inputBuffer;

    // Start is called before the first frame update
    void Start()
    {
        inputBuffer = 0;
         gridNode = currentGridSpace.GetComponent<GridNode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (gridNode.TopNeighbor != null)
            {
                GetTopNeighbor();
            }
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (gridNode.BottomNeighbor != null)
            {
                GetBottomNeighbor();
            }
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gridNode.LeftNeighbor != null)
            {
                GetLeftNeighbor();
            }
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gridNode.RightNeighbor != null)
            {
                GetRightNeighbor();
            }
        }
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
}
