using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            MoveManager.Instance.MoveRight = true;
        }
        else
        {
            MoveManager.Instance.MoveRight = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoveManager.Instance.MoveLeft = true;
        }
        else
        {
            MoveManager.Instance.MoveLeft = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            MoveManager.Instance.Jump = true;
        }
        else
        {
            MoveManager.Instance.Jump = false;
        }
    }

}

