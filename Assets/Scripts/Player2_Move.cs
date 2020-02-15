using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float velY = 17f;
    public float velX = 17f;
    public bool isGrounded = false;
    public bool isDead = false;
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
            Debug.Log("unhit");
            isGrounded = false;
        } 
        if(isGrounded){
            // Debug.Log("efkfbw")
            if(Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.LeftArrow)) {
                rb.velocity = Vector2.left * velX;
            } if(Input.GetKey(KeyCode.L) || Input.GetKey(KeyCode.RightArrow)) {
                rb.velocity = Vector2.right * velX;
            }
        } else {
            if(Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.LeftArrow)) {
                rb.velocity = Vector2.left * velX;
            } if(Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.RightArrow)) {
                rb.velocity = Vector2.right * velX;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "ground"){
            Debug.Log("hit");
            isGrounded = true;
        }
    }

    // void OnCollisionExit2D(Collision2D col){
    //     if(col.gameObject.tag != "ground"){
    //         isGrounded = false;
    //     }
    // }

// private void OnCollisionStay2D(Collision2D col){
//     if(col.gameObject.tag == "ground"){
//         Debug.Log("ths i sso sad");
//         isGrounded = true;
//     }
// }
}
