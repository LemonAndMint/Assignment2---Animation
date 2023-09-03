using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public Animator animator;
    int forward, jump;

    void Start()
    {
        
        forward = Animator.StringToHash("forward");
        jump = Animator.StringToHash("jump");
    
    }
    
    void Update()
    {
    
        bool forwardInput = Input.GetKey(KeyCode.W);
        bool jumpInput = Input.GetKeyDown(KeyCode.Space);

        animator.SetBool( forward, forwardInput );
        animator.SetBool( jump, jumpInput );

    }

}

