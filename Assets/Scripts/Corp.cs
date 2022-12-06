using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corp : MonoBehaviour
{
    Rigidbody rd;
    int speed=8;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity = new Vector3(speed, 0, 0);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("lft"))
            speed *= -1;
    }
}
