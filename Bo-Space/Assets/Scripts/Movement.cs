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
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));

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
