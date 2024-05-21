using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
    private bool isGrounded;
    public float Speed;
    private Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        Speed = 2f;
        if (MoveManager.Instance.MoveRight && MoveManager.Instance.MoveLeft)
        {
            return;
        }
        if (MoveManager.Instance.MoveRight)
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, -180f, 0f);
        }
        else if (MoveManager.Instance.MoveLeft)
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (MoveManager.Instance.Jump && isGrounded)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            isGrounded = false; // player är inte grounded
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}




