using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource jumpSound;
    public AudioSource landSound;
    public AudioSource walkSound;

    public float jumpFrequencyLimit = 1.0f;
    public float jumpCountLimit = 2;
    public float jumpForce = 5.0f;

    public bool isGrounded;

    private float jumpTimer;
    private int jumpCounter;

    // Start is called before the first frame update
    void Start()
    {
        jumpTimer = Time.fixedTime - jumpFrequencyLimit;
        jumpCounter = 0;
        isGrounded = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // If Player is on the ground...
        if (isGrounded)
        {
            Debug.Log(transform.position.y);
            // ...reset the jump counter
            jumpCounter = 0;
            // ...set the position to the ground position
            Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
            // ... get rid of the downforce
            rb.AddForce(Vector2.up*rb.velocity.y);
            
        }

        // If W is pressed,
        // the jump counter is less than or equal to the limit,
        // and the current time is greater than the last jump time plus the jump frequency limit...
        if (Input.GetKeyDown(KeyCode.W) && jumpCounter <= jumpCountLimit && Time.fixedTime > jumpTimer + jumpFrequencyLimit)
        {
            // Add an upward force to the player
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            // Increment jump counter
            jumpCounter += 1;
            // Set the jump timer to now
            jumpTimer = Time.fixedTime;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If player is colliding with the ground layer...
        if (collision.collider.tag == "Ground")
            // ...set the player to grounded
            landSound.Play();
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // If player is no longer colliding with the ground layer...
        if (collision.collider.tag == "Ground")
            // ...unset isGrounded
            isGrounded = false;
            jumpSound.Play();
    }

}
