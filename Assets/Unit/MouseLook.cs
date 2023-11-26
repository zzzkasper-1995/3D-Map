using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 80f;

    public Transform playerBody;
    
    private float yRotation = 0f;
    
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        var mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        var mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -45f, 100f);
        
        transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}