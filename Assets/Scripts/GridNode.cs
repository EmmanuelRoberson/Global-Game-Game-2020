using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour
{
    public GameObject nodeObject;

    public Vector3 sitPosition;

    public GridNode RightNeighbor;
    public GridNode LeftNeighbor;
    public GridNode TopNeighbor;
    public GridNode BottomNeighbor;
}