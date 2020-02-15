using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float velY = 17f;
    public float velX = 17f;
    public bool isGrounded = false;
    public bool isDead = false;

    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.W)) {
            rb.velocity = Vector2.up * velY;
            Debug.Log("unhit");
            isGrounded = false;
        } 
        if(isGrounded){
            // Debug.Log("efkfbw")
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

        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp (pos.x, -Screen.width, Screen.width);
        pos.y = Mathf.Clamp (pos.y, -Screen.height, Screen.height);
        transform.position = pos;
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
