using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveManager : MonoBehaviour
{


    
    public static MoveManager Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }

    }

    public bool MoveRight;
    public bool MoveLeft;
    public bool Jump;
    public bool IsGrounded;

}
