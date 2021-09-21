using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {   
       if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
       if(Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.Green;
        }
       if(Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Rendere>().material.color = Color.Blue;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
