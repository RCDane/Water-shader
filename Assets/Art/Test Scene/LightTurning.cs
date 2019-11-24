using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTurning : MonoBehaviour
{
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(-speed*Time.deltaTime,0,0);
        transform.Rotate(rotation,Space.Self);  
    }
}
