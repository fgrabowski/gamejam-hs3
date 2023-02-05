using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject root;
    
    void Start()
    {
        GameObject newroot = Instantiate(root);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            timer = 0;
            GameObject newroot = Instantiate(root);
            newroot.transform.position = transform.position;
            Destroy(newroot, 20);
            maxTime = Random.Range(3, 8);
        }
        
        timer += Time.deltaTime;
    }
    
    private void LateUpdate()
    {
        
    }
    
}
