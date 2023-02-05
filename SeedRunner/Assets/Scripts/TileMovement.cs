using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    public float tile_speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * tile_speed * Time.deltaTime;
        if(transform.position.x < -24)
        {
            transform.Translate(37.63f, 0, 0);
        }
    }
}
