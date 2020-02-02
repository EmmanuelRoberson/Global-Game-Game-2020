using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RhythmTool;
using UnityEngine;
using UnityEngineInternal;

public class GridTraversalBehaviour : MonoBehaviour
{
    private bool Count3;
    private bool count2;
    private bool count1;

    private bool go;
        
    public GameObject currentGridSpace;
    private GridNode gridNode;
    private float inputBuffer;
    private float inputBufferTimer;

    private bool canMove;

    public RhythmEventProvider eventProvider;
    
    // Start is called before the first frame update
    void Awake()
    {
        eventProvider.Register<Beat>(MoveFunction);

        inputBuffer = 0.2f;
        inputBufferTimer = 0;
        gridNode = currentGridSpace.GetComponent<GridNode>();
        transform.position = gridNode.sitPosition;
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
        gridNode.isOccupied = false;

        gridNode = gridNode.TopNeighbor;
        gridNode.isOccupied = true;
    }
    
    public void GetBottomNeighbor()
    {
        transform.position = gridNode.BottomNeighbor.sitPosition;
        gridNode.isOccupied = false;
        
        gridNode = gridNode.BottomNeighbor;
        gridNode.isOccupied = true;
    }
    
    public void GetLeftNeighbor()
    {
        transform.position = gridNode.LeftNeighbor.sitPosition;
        gridNode.isOccupied = false;
        
        gridNode = gridNode.LeftNeighbor;
        gridNode.isOccupied = true;
    }
    
    public void GetRightNeighbor()
    {
        transform.position = gridNode.RightNeighbor.sitPosition;
        gridNode.isOccupied = false;
        
        gridNode = gridNode.RightNeighbor;
        gridNode.isOccupied = true;
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
