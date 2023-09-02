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
    
        bool forwardAnimBool = animator.GetBool(forward);
        bool jumpAnimBool = animator.GetBool(jump);

        bool forwardInput = Input.GetKey(KeyCode.W);
        bool jumpInput = Input.GetKey(KeyCode.Space);

        if(!forwardAnimBool && forwardInput)
        {
            animator.SetBool(forward, true);
        }
        if (forwardAnimBool && !forwardInput)
        {
            animator.SetBool(forward, false);
        }


        if (!jumpAnimBool && jumpInput)
        {
            animator.SetBool(jump, true);
        }
        if (jumpAnimBool && !jumpInput)
        {
            animator.SetBool(jump, false);
        }
    
    }


}

