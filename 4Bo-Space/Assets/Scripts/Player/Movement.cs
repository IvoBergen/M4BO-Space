using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public bool isMoving;
    public int sprint = 20;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    float horizontalInput;
    float verticalInput;
    public bool isSprinting;
    public float stamina;


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
    }

    private void FixedUpdate()
    {

        MovePlayer();

        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (Input.GetKey(KeyCode.LeftShift) & isMoving == true) //sprint function
        {
            moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput * sprint;
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }

        if ((isMoving) & (Input.GetKey(KeyCode.LeftShift) == true)) //checks if the player is suing sprint
        {
            isSprinting = true;
        }
        else 
        {
            isSprinting = false;
        }

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
