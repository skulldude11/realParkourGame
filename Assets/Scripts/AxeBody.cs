using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            transform.localScale = new Vector3( 10.0f, 10.0f, 15.0f);
        }

        else
        {
            transform.localScale = new Vector3(10.0f, 10.0f, 10.0f);
        }
    }
}
