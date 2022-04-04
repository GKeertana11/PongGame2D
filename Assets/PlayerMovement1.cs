using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        movement.y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(0, movement.y * speed);
        /* if (Input.GetKeyDown(KeyCode.LeftAlt))
         {
             transform.Translate(0, speed, 0);
         }

         if (Input.GetKeyDown(KeyCode.RightAlt))
         {
             transform.Translate(0, -speed, 0);
         }*/
    }
}

