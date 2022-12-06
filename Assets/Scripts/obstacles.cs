using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public GameObject[] obstaclsPos;
    public GameObject[] obstaclsPref;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<obstaclsPos.Length;i++)
        {
            int rand = Random.Range(0, 2);
            GameObject obs = Instantiate(obstaclsPref[rand], obstaclsPos[i].transform.position, Quaternion.identity); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
