using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] internal float speed = 1600f;
    [SerializeField] internal float rotSpeed = 100f;
    public float sprint = 25f;
    private Rigidbody rb;
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
