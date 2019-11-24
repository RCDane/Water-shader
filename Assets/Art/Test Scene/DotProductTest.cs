using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float dot = Vector3.Dot(new Vector3(-1,0,0),new Vector3(-1,0,0));
        Debug.Log(dot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
