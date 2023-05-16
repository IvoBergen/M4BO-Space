using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    float horizontalInput;
    float verticalInput;

    public Transform orientation;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void Update()
    {
        // ground check
        grounded = Physics.Raycast(transform.position, Vector3.down , playerHeight * 0.5f + 0.2f, whatIsGround);
        MyInput();

        //handle drag
        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;
    }

    private void FixedUpdate()
    {
<<<<<<< HEAD
        MovePlayer();
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.position += new Vector3(0, 0, -2) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position += new Vector3(-2, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKeyDown("w"))
        {
            isMoving = true;
        }
        if (Input.GetKeyUp("w"))
        {
            isMoving = false;
        }
        if (Input.GetKey(KeyCode.LeftShift) & isMoving == true) 
        {
            transform.position += transform.forward * Time.deltaTime * sprint;
        }
>>>>>>> d9d9aaae23c1982c527c2f9dcfeb69114f343eb6
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward* verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

}
