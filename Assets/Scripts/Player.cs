using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   [SerializeField] GameObject lose;
    [SerializeField] GameObject win;
    float i = 8;
    Rigidbody rd;
    [SerializeField] GameObject Kora;
    Transform pl;
    int pos = 2;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            Vector3 currentMousee = new Vector3(Input.mousePosition.x*3.5f/Screen.width, transform.position.y, transform.position.z);
            transform.position = currentMousee;
        }

        rd.velocity = new Vector3(0, 0, i);
        if(Time.timeScale==1)
        i += 0.04f;


        //if (Input.GetKey("right"))
        //{
        //    rd.velocity = new Vector3(0, 0, 2);
        //    rd.velocity = new Vector3(5, 0, 0);
        //}
        //if (Input.GetKey("left"))
        //{
        //    rd.velocity = new Vector3(0, 0, 2);
        //    rd.velocity = new Vector3(-5, 0, 0);
        //}
        //if (Playerss.join == true)
        //{         
        //    Vector3 ab = new Vector3(transform.position.x,transform.position.y,transform.position.z - pos);
        //    pl.position = ab;
        //    pos -= 2;
        //    Instantiate(Kora, pl.position, Quaternion.identity);
        //    Playerss.join = false;
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("playerss"))
        {
            Vector3 ab = new Vector3(transform.position.x, transform.position.y, transform.position.z - pos);

            pos += 2;
            Debug.Log("a");
            Instantiate(Kora, ab, Quaternion.identity);
            Debug.Log("a");
            Playerss.join = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        //if (other.gameObject.CompareTag("obstcl") || other.gameObject.CompareTag("ground2"))
        //{
        //    Time.timeScale = 0;
        //    transform.localScale = new Vector3(0, 0, 0);
        //    lose.SetActive(true);
        //}
        if (other.gameObject.CompareTag("playerss"))
        {
            Vector3 ab = new Vector3(transform.position.x, transform.position.y, transform.position.z - pos);

            pos += 2;
            Debug.Log("a");
            Instantiate(Kora, ab, Quaternion.identity);
            Debug.Log("a");
            Playerss.join = false;
        }
        //if (other.gameObject.CompareTag("win"))
        //{
        //    win.SetActive(true);
        //}
    }
}
