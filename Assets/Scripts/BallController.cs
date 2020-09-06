using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool left;
    private bool right;
    private bool jump = false;

    public bool isLanded;
    public LayerMask lm;
    public float ballPostion;
    


    Vector3 startPos;
    public static bool enemyMove;
    public float position;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        enemyMove = false;
       
    }

    

    // Update is called once per frame
    void Update()
    {
        
        if(left == true || Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed;
        }
        else if(right == true || Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * speed;
        }
        else if(left == false || right == false)
        {
            rb.velocity = Vector2.zero;
        }
        if (jump == true || Input.GetKey(KeyCode.Space))
        {
            if (isLanded == true)
            {
                rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode2D.Impulse);
            }
            
        }

        if(transform.position.x >= position)
        {
            enemyMove = true;
        }

    }

    public void moveLeft()
    {
        left = true;
        
    }

    public void moveRight()
    {
        right = true;
        
    }

    public void doJump()
    {
        jump = true;
        
    }

    public void doNotJump()
    {
        jump = false;
        
    }

    public void stopMove()
    {
        left = false;
        right = false;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isLanded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isLanded = false;
        }
    }
}
