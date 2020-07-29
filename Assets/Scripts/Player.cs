using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;
    public float jumpPower;
    public float maxSpeed;
    public float reduceSpeed;
    public int flowerCount;
    public GameManager manager;
    bool CanJump;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        CanJump = true;
    }

    void Update()
    {
        //jump
        if (Input.GetButtonDown("Jump") && !anim.GetBool("IsJumping") && CanJump)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
        }
        //break when button up
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * reduceSpeed, rigid.velocity.y);
        }
        //flip player
        if (Input.GetButton("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }
        //set,reset walk animation
        if (Mathf.Abs(rigid.velocity.x) < 0.3f)
        {
            anim.SetBool("IsWalking", false);
        }
        else
        {
            anim.SetBool("IsWalking", true);
        }


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flower")
        {
            flowerCount++;
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "Finish")
        {
            // Clear
            if (flowerCount == manager.totalItemCount)
            {

            }
            // Restart
            else
            {
                SceneManager.LoadScene("Tutorial1");
            }
        }
    }

    void FixedUpdate()
    {
        //move(left,right)
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        //maxSpeed control
        if (rigid.velocity.x > maxSpeed)
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }

        else if (rigid.velocity.x < maxSpeed * (-1))
        {
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
        Vector2 frontVec = new Vector2(rigid.position.x + 0.4f, rigid.position.y);
        Vector2 backVec = new Vector2(rigid.position.x + -0.4f, rigid.position.y);
        Debug.DrawRay(frontVec, Vector3.down, new Color(0, 1, 0));
        Debug.DrawRay(backVec, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit_f = Physics2D.Raycast(frontVec, Vector3.down, 1.2f, LayerMask.GetMask("Platform"));
        RaycastHit2D rayHit_b = Physics2D.Raycast(backVec, Vector3.down, 1.2f, LayerMask.GetMask("Platform"));
        //when falling
        //set layer as "Platform"
        if (rayHit_f.collider != null || rayHit_b.collider != null)
        {
            CanJump = true;
            if (rayHit_f.distance < 1.3f || rayHit_b.distance < 1.3f)
                anim.SetBool("IsJumping", false);
        }
        else
        {
            CanJump = false;
        }
        
    }
}
