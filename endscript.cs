using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endscript : MonoBehaviour
{
    public game_manager  gamemanager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamemanager.completeLevel();
    }
}
