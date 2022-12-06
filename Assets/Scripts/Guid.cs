using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Guid : MonoBehaviour
{
    public static int scoreK;
    public static Text textScoe;
    //public static int index;
    public GameObject koralist;
    GameObject player1;
    GameObject ballfollow;
    [SerializeField] GameObject lose;
    public static List<GameObject> l = new List<GameObject>();
    
    //public GameObject ball;
    float i = 8;
    Rigidbody rd;
    Transform t;
    public static int pos = 2;
    // Start is called before the first frame update
    void Start()
    {
        for(int j=0; j <l.Count;i++)
        {
            l.Remove(l[j]);
        }
        textScoe = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        scoreK = 0;
        rd = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        Vector3 posPlayer = new Vector3(transform.position.x, transform.position.y, transform.position.z );
        player1=Instantiate(koralist, posPlayer , Quaternion.identity);
        //Camera.camerafollow = player1.transform;
        //l.Add(player1);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Guid.l.Count == 0)
            lose.SetActive(true);

            if (Input.GetMouseButton(0))
        {
            Vector3 currentMousee = new Vector3(Input.mousePosition.x * 3.5f / Screen.width, transform.position.y, transform.position.z);
            transform.position = currentMousee;
        }

        rd.velocity = new Vector3(0, 0, i);

        if (Time.timeScale == 1)
            i += 0.02f;

        if (Kora.dest == true)
        {
            for (int i = Kora.destIndex; i < l.Count - 1; i++)
            {

                l[i].transform.position = l[i + 1].transform.position;
                if (i == l.Count - 1)
                    l.Remove(l[i]);

            }
            Kora.dest = false;
            //Camera.camerafollow = l[0].transform;
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.CompareTag("playerss"))
        {
            pos += 2;

            Vector3 posPlayer = new Vector3(transform.position.x, transform.position.y, (transform.position.z - pos));
            //pos += 2;

            Instantiate(koralist, posPlayer, Quaternion.identity);
            
            Playerss.join = false;
            Destroy(other.gameObject);

            scoreK += 1;
            Guid.textScoe.text = Guid.scoreK.ToString();
        }
       
    }
}
