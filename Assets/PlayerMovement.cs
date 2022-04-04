using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
        movement.y= Input.GetAxis("Vertical1");
        rb.velocity = new Vector2(0, movement.y*speed);
      //  movement.y = Input.GetAxis("Vertical");

      /*  if(Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            transform.Translate(0,speed,0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0,-speed,0);
        }*/
    }
  
}
