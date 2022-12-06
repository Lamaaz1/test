using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Playerss : MonoBehaviour
{

    public static bool join = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player"))
        {

            Destroy(gameObject);
            join = true;
        }

    }
}