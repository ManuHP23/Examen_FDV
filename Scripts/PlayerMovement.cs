using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canJump;
    public bool isGrounded;
    public bool walking;
    public int forceHorizontal;
    public int forceVertical;

    void Start()
    {
        walking = false;
        canJump = true;
        isGrounded = true;
    }

    void FixedUpdate()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-forceHorizontal * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("walking", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(forceHorizontal * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("walking", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("walking", false);
        }

        if (Input.GetKeyDown("up") && (canJump == true) && (isGrounded == true))
        {
            gameObject.GetComponent<Animator>().SetBool("canJump", false);
            gameObject.GetComponent<Animator>().SetBool("isGrounded", false);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forceVertical));
            canJump = false;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            gameObject.GetComponent<Animator>().SetBool("canJump", true);
            gameObject.GetComponent<Animator>().SetBool("isGrounded", true);
            canJump = true;
            isGrounded = true;
        }
    }
}
