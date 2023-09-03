using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private float _xAxis, _yAxis;
    void Start()
    {
        
    }

    void Update()
    {

        _xAxis = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        _yAxis = -1 * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.position += new Vector3(_xAxis, 0 , _yAxis);

    }
}
