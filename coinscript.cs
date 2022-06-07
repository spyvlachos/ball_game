using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscript : MonoBehaviour
{
    
    public int coinscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //your player should have the "player" tag
        if (col.CompareTag("Player"))
        {
            coinscript1.coinAmount += 1;
            //remove the coin
            Destroy(gameObject);
            //you should also have a manager class where you store your score and other useful stuff
            
        }
    }
    // Update is called once per frame
    void Update()
    {
       
        
    }
}
