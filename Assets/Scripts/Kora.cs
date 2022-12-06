using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kora : MonoBehaviour
{
    float Spd;
    public static bool dest;
    public static int destIndex;
    //int index;
    GameObject player;
    //the object to follow
     GameObject guidobject;
    //max distance
    public float maxDistance;
    public GameObject lastone;
    [SerializeField] float speed=100f;
    //angular speed radius
    float z;
    //bool b = false;
    //int j;
    Rigidbody rd;
    float i = 8;
    int ij;
     GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        Spd = 0;
       
      
        maxDistance = Guid.pos;
        lose = GameObject.FindGameObjectWithTag("lose");
        guidobject = GameObject.FindGameObjectWithTag("guid");
        Guid.l.Add(gameObject);
        
         
        //Debug.Log(index);
        
        
        rd = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("player");
        //z = lastone.transform.position.z - gameObject.transform.position.z;
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Guid.l.IndexOf(this.gameObject) == 0)
            transform.position = new Vector3(guidobject.transform.position.x, guidobject.transform.position.y, guidobject.transform.position.z);
        else if (Guid.l.IndexOf(this.gameObject) > 0)
        {
            if (Guid.l.IndexOf(this.gameObject) >= 1)
                ij = Guid.l.IndexOf(this.gameObject) - 1;
            lastone = Guid.l[ij];
            //maxDistance = 3 * Guid.l.IndexOf(this.gameObject);
            maxDistance = 2;
            float actualDistance = Vector3.Distance(transform.position, lastone.transform.position);
            if(actualDistance>maxDistance)
            transform.position = Vector3.MoveTowards(transform.position , lastone.transform.position  , speed*Time.deltaTime*(10+Spd));
          

        }
        if (Time.timeScale == 1)
            Spd += 0.03f;

    }
    private void OnTriggerEnter(Collider other)
        {


            if (other.gameObject.CompareTag("obstcl"))
            {

            if (Guid.l.Count == 1)
            {
                Debug.Log("khserna");
                Time.timeScale = 0;
                transform.localScale = new Vector3(0, 0, 0);
                lose.SetActive(true);
            }

            Guid.scoreK = -1;
            Guid.textScoe.text = Guid.scoreK.ToString();

            destIndex = Guid.l.IndexOf(this.gameObject);
              dest = true;
            Guid.l.Remove(Guid.l[destIndex]);
            Destroy(gameObject);
            }
            //if (other.gameObject.CompareTag("sh"))
            //{
            //    b = true;
            //}
        }
 }

