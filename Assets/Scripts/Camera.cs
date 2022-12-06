using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   //public static Transform camerafollow ;
    // Start is called before the first frame update
    void Start()
    {
        //player = Guid.l[0].transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (Guid.l.Count >= 1)
            transform.position = new Vector3(transform.position.x, transform.position.y, Guid.l[0].transform.position.z - 17.96f) ;
    }
}
