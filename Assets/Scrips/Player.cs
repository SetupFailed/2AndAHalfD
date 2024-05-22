using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
   
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

        if (MoveManager.Instance.Jump && MoveManager.Instance.IsGrounded)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            MoveManager.Instance.IsGrounded = false; 
            MoveManager.Instance.Jump = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            MoveManager.Instance.IsGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            MoveManager.Instance.IsGrounded = false;
        }
    }

}




