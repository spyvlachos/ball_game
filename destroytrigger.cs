using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroytrigger : MonoBehaviour
{
    // Start is called before the first frame update
  



    private void OnTriggerEnter2D(Collider2D col)
    {
        //your player should have the "player" tag
        if (col.CompareTag("destroytrig"))
        {
            Debug.Log("hit");
            //remove the coin
            Destroy(gameObject);
            
        }
    }

}
