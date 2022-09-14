using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float moveSpeed = 100f;

    public Rigidbody2D rb;

    Vector2 movement;



    private int vel;
     void Update()
    {
        vel =100;
        movement.x = Input.GetAxisRaw("Horizontal2");


    }


    private void FixedUpdate()
    {
        vel = 15;

        if (Input.GetKey(KeyCode.LeftShift)) {
            vel = 30;
        }

        rb.MovePosition(rb.position + movement * vel * Time.fixedDeltaTime);    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Enemy")
      {
          SceneManager.LoadScene("gameover");
      }

    }
}
