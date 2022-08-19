using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermouvment : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed;
    public float jumpforce;
    private bool isGround;
    public bool isJumping;
    private bool doublejump;

    private float coyotetime = 0.2f;
    private float coyotetimeCounter;

    private Vector3 respawnpoint;
    public GameObject fallDetector;
    void Start()
    {
        respawnpoint = transform.position;
    }
    void Update()
    {
        //mouvment
        float h = Input.GetAxis("Horizontal")* speed;
        rb2D.velocity = new Vector2(h , rb2D.velocity.y);
        GetComponent<Animator>().SetFloat("speed", Mathf.Abs(h));
        if (rb2D.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (rb2D.velocity.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }


        //jumping
        if (Input.GetButtonDown("Jump") )
        {
            if (isJumping == false || doublejump) { 
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpforce );
                doublejump = !doublejump;
            }
        }
        if (isJumping = false && !Input.GetButton("jump"))
        {
            doublejump = false;
        }
        
        else if (Input.GetButtonDown("Jump") && isJumping == true)
        {
            rb2D.AddForce(new Vector2(rb2D.velocity.x, rb2D.velocity.y * 0.1f)) ;
        }
        if (Input.GetButtonUp("Jump")&& rb2D.velocity.y > 0)
        { 
            rb2D.velocity = new Vector2(rb2D.velocity.x, rb2D.velocity.y * 0.1f);
        }

        //animetion
        GetComponent<Animator>().SetBool("jump?", Input.GetButtonDown("Jump"));
        GetComponent<Animator>().SetFloat("yVelocity", rb2D.velocity.y);

        if (rb2D.velocity.y !=0)
        {
            isGround = false;
            isJumping = true;
        }
        else
        {
            isGround = true;
          isJumping = false;
        }
        //double jump

        //mouvment animation
        if (h == 0)
        {
            GetComponent<Animator>().SetBool("true1", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("true1", false);
        }
        //checkpoint
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
        
        
    }
    //respoint and indexLevels
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.tag == "falldetector" || collision.tag == "danger")
            {
             transform.position = respawnpoint;
            }
          else if  (collision.tag == "CHECKPOINT")
          {
            respawnpoint = transform.position;
          }
          else if (collision.tag == "nextLevel")
          {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            respawnpoint = transform.position;
          }
        else if (collision.tag == "previousLevel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            respawnpoint = transform.position;
        }
    }
}
