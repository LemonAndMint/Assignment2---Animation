using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;

    public float moveSpeed;
    public float jumpSpeed;

    public bool isJumping = false;

    private float _xAxis, _yAxis;
   
    void Update()
    {

        _xAxis = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        _yAxis = -1 * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //Input varsa, ziplama hareketi yoksa ve ziplama animasyonu calisiyorsa
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && animator.GetBool("jump"))
        {

            rb.velocity = Vector3.up * jumpSpeed;

        }

        transform.position += new Vector3(_xAxis, 0 , _yAxis);

    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Ground") { isJumping = false; }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") { isJumping = true; }
    }

}
