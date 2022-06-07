using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grappler : MonoBehaviour
{


    public Camera maincamera;
    public LineRenderer linerend;
    public DistanceJoint2D distjoint;
    private Vector3 horizontalMovement;
    public bool clickhook = false;
    public bool firsttime = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        distjoint.enabled = false;

    }

  //  private void OnTriggerEnter2D(Collider2D other)
   // {
     //   if (other.gameObject.CompareTag("coin"))
       // {
         //   Destroy(other.gameObject);
           // coinscore = coinscore + 1;
        //}
    //}

    // Update is called once per frame
    void Update()
    { 
       

            if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (firsttime == true)
            {
                Time.timeScale = 1;
                firsttime = false;
            }
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
            if (hits2D.transform != null)
            {
                if (hits2D.collider.tag == "hook")
                {
                    clickhook = true;

                }
                else if (hits2D.collider == null)
                {
                    clickhook = false;
                }
            }


            Vector2 mouspos = (Vector2)maincamera.ScreenToWorldPoint(Input.mousePosition);
            linerend.SetPosition(0, mouspos);
            linerend.SetPosition(1, transform.position);
            distjoint.connectedAnchor = mouspos;
            if (clickhook == true)
            {
                distjoint.enabled = true;
                linerend.enabled = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            clickhook = false;
            distjoint.enabled = false;
            linerend.enabled = false;
        }
        if (distjoint.enabled)
        {
            linerend.SetPosition(1, transform.position);
        }
    }
}
