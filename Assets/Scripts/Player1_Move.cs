using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float velY = 17f;
    public float velX = 5f;
    public bool isGrounded = true;
    public LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.W) && isGrounded) {
            rb.velocity = Vector2.up * velY;
        } 
        if(isGrounded) {
            if(Input.GetKey(KeyCode.A)) {
                rb.velocity = Vector2.left * velX;
            } if(Input.GetKey(KeyCode.D)) {
                rb.velocity = Vector2.right * velX;
            }  
        } else {
            if(Input.GetKeyDown(KeyCode.A)) {
                rb.velocity = Vector2.left * velX;
            } if(Input.GetKeyDown(KeyCode.D)) {
                rb.velocity = Vector2.right * velX;
            }
        }
        
    }
}


