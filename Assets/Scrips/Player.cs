using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
   
    public float Speed;
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

        else if (MoveManager.Instance.Jump)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);

        }

    }
    

}
