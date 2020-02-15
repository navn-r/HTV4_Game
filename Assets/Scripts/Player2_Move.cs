using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float velY = 17f;
    public float velX = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.velocity = Vector2.up * velY;
        } if(Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            rb.velocity = Vector2.left * velX;
        } if(Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.RightArrow)) {
            rb.velocity = Vector2.right * velX;
        }
        
    }
}
