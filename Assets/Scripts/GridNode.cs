using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GridNode : MonoBehaviour
{
    public GameObject nodeObject;

    public Vector3 sitPosition;

    public GridNode RightNeighbor;
    public GridNode LeftNeighbor;
    public GridNode TopNeighbor;
    public GridNode BottomNeighbor;

    private void Start()
    {
        sitPosition = transform.position + new Vector3(0, 1, 0);
    }
}