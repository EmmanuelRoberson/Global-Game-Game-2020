using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RhythmTool;
using UnityEngine;
using UnityEngineInternal;

public class GridTraversalBehaviour : MonoBehaviour
{
    public GameObject currentGridSpace;
    private GridNode gridNode;
    private float inputBuffer;
    private float inputBufferTimer;

    private bool canMove;

    public RhythmEventProvider eventProvider;
    
    // Start is called before the first frame update
    void Start()
    {
        eventProvider.Register<Beat>(MoveFunction);
        
        inputBuffer = 0.2f;
        inputBufferTimer = 0;
        gridNode = currentGridSpace.GetComponent<GridNode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
            inputBufferTimer += Time.deltaTime;
        
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

    public void MoveFunction(Beat beat)
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (gridNode.TopNeighbor != null)
            {
                inputBufferTimer = 0;
                GetTopNeighbor();
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (gridNode.BottomNeighbor != null)
            {
                inputBufferTimer = 0;
                GetBottomNeighbor();
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gridNode.LeftNeighbor != null)
            {
                inputBufferTimer = 0;
                GetLeftNeighbor();
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gridNode.RightNeighbor != null)
            {
                inputBufferTimer = 0;
                GetRightNeighbor();
            }
        }
    }
}
