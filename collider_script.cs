﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_script  : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        if (collisioninfo.collider.tag == "collider")
        {
            FindObjectOfType<game_manager>().EndGame();
            
        }
    }
   
}
