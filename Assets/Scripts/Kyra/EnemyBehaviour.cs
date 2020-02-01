using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
  //begin emmanuel code
  private bool canMove;

  /// <summary>
  /// this will tell them if they can move or not
  /// </summary>
  public void MoveSwitch()
  {
    canMove = !canMove;
  }

  /// <summary>
  /// this is so the enemies have to wait to move
  /// </summary>
  private float timeUntilMoveIsAllowed = 0;
  //end emmanuel code

  private void Start()
  {
    canMove = false;
  }

  private void Update()
  {
    if (timeUntilMoveIsAllowed > 1)
    {
      //move logic goes here, refer to my grid traversal behaviour for reference
      
      
    }

    
    timeUntilMoveIsAllowed += Time.deltaTime;
  }
  
}
