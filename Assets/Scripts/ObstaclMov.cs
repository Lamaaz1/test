using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclMov : MonoBehaviour
{
    float count = 0;
    bool fliped=false;
    float speed = 0.5f;
    Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity += new Vector3(speed, 0, 0);

        
        //if (transform.position.x < 5f && transform.position.x > -3f)
        //{
        //    fliped = false;
           
        //}
          

        //    if (((transform.position.x> 5f)||( transform.position.x<-3f))&&fliped==false)
        //{
        //    //while(count >= 0)
        //    //{
        //    //    count -= Time.deltaTime;
        //    //    fliped = true;
        //    //}
        //    speed =-1*speed;
           
        //    //count = 2;


        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("support"))
        {
            speed*=-1;
            fliped = true;
        }
        else
        {
            fliped = false;

        }
    }

}
