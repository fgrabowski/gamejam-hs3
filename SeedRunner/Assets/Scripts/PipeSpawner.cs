using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject root;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newroot = Instantiate(root);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            timer = 0;
            GameObject newroot = Instantiate(root);
            newroot.transform.position = transform.position;
            Destroy(newroot, 20);
            maxTime = Random.Range(3, 15);
        }
        
        timer += Time.deltaTime;
    }
    
    private void LateUpdate()
    {
        
    }
    
}
