using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Move_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool revers = false;
    private bool isGrounded = false;
    public Animator _animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Revers(moveHorizontal);

        if (Mathf.Abs(moveHorizontal) > 0)
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                _animator.SetInteger("isRun", 2);
            }
            else _animator.SetInteger("isRun", 1);
        }
        else _animator.SetInteger("isRun", 0);

        
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

      

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("isJump", true);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void Revers(float moveX)
    {
        if (moveX < 0 && !revers)
        {
            revers = true;
            transform.Rotate(Vector3.up, 180f);
        }
        else if(moveX > 0 && revers)
        {
            revers = false;
            transform.Rotate(Vector3.up, 180f);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            _animator.SetBool("isJump", false);
        }
    }
}
