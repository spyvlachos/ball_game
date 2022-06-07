using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool ispressed = false;
    public float ReleaseTime = .15f;
    public Rigidbody2D hook;
    public float maxDragDistance = 2f;
    

    void OnMouseDown()
    {
        ispressed = true;
        rb.isKinematic = true;
        


    }

    void OnMouseUp()
    {
        ispressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        if (ispressed)
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            if (Vector3.Distance(mousepos,hook.position) > 2)
                rb.position = hook.position + (mousepos - hook.position).normalized * maxDragDistance ;
            else
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }




    }
    IEnumerator Release()
    {
        yield return new WaitForSeconds(ReleaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
    }




 
}
