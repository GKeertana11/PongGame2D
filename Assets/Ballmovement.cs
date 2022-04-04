using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballmovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public int score1;
    public Text scoretext1;
    public int score2;
    public Text scoretext2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Lauch();
    }

    private void Lauch()
    {
       float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
       rb.velocity = new Vector2(x * speed, y * speed);
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(speed, speed, 0);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "left")
        {
            score2 = score2 + 1;
            scoretext2.text = score2.ToString();
        }

        if (collision.gameObject.tag == "right")
        {
            score1 = score1 + 1;
            scoretext1.text = score1.ToString();
        }
    }
}
