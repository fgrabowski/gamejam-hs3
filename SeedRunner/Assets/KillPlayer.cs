using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public GameObject DeathScreen;
    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.name == "Player")
        {
            Debug.Log("Hit");
            DeathScreen.SetActive(true);
        }

    }
}
