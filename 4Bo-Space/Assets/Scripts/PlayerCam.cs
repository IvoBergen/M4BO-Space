using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float SensY;
    public float SensX;
    public bool locked;

    public Transform orientation;

    public float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        if (locked == false)
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * SensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * SensY;

            yRotation += mouseX;

            xRotation -= mouseY;

            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        }

    }
}
