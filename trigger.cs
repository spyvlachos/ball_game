using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject somePrefab;

    private void OnTriggerEnter2D()
    {
      
       
            somePrefab.GetComponent<SpringJoint2D>().attachedRigidbody.tag = "hook";
            somePrefab.GetComponent<SpringJoint2D>().enabled = true;
       

    }
    
}
