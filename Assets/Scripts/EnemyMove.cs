using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player1"))
        {
            collide.GetComponent<Player1_Move>().isDead = true;
            Debug.Log(collide.GetComponent<Player1_Move>().isDead);
            Application.LoadLevel(Application.loadedLevel);

        } if (collide.CompareTag("Player2")) {
            collide.GetComponent<Player2_Move>().isDead = true;
            Debug.Log(collide.GetComponent<Player2_Move>().isDead);
            Application.LoadLevel(Application.loadedLevel);

        } 
    }
    
}
