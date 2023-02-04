using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootsMovement : MonoBehaviour
{
    
    public float root_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * root_speed * Time.deltaTime;
    }
}
