using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jumpFrequencyLimit = 1.0f;
    public float jumpCountLimit = 2;
    public float groundPosY = 1;
    public bool keyW;

    private float jumpTimer;
    private int jumpCounter;


    // Start is called before the first frame update
    void Start()
    {
        jumpTimer = Time.fixedTime - jumpFrequencyLimit;
        jumpCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        keyW = Input.GetKey(KeyCode.W);
        // If Player is on the ground...
        if (transform.position.y == groundPosY)
        {
            // ...reset the jump counter
            jumpCounter = 0;
        }

        // If W is pressed,
        // the jump counter is less than or equal to the limit,
        // and the jump timer is greater than the frequency limit...
        if (Input.GetKeyDown(KeyCode.W) && jumpTimer > Time.fixedTime + jumpFrequencyLimit && jumpCounter <= jumpCountLimit)
        {
            Debug.Log("jump");
        }
    }
}
