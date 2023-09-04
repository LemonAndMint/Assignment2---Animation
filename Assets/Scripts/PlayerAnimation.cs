using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public Animator animator;
    public PlayerMovement playerMovement;

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

        //Ziplama durumu yoksa oyuncu girisine gore ziplama animasyonunu calistirir.
        //Eger ziplama durumu varsa havada kalma animasyonu icin "jump" boolu surekli true yapilir. 
        //Bu sayede havada kalma animasyonu yere dusene kadar devam eder.
        if (!playerMovement.isJumping) { animator.SetBool( jump, jumpInput ); } 
        else { animator.SetBool(jump, true); }

    }

}

