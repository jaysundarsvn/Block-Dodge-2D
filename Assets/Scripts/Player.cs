using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float pos;
    public bool canMove = true;
    float xInput;
  



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Input.mousePosition;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);

            if (touchPos.x < 0)
            {
                // transform.position += Vector3.left * speed * Time.deltaTime; 
                rb.AddForce(Vector2.left * speed);

            }
            else
            {
                // transform.position += Vector3.right * speed * Time.deltaTime;
                rb.AddForce(Vector2.right * speed);
            }

        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        float xPos = Mathf.Clamp(transform.position.x, -pos, pos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Crate")
        {
            SceneManager.LoadScene(0);
        }
    }    
}
