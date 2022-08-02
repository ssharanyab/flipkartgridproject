using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float move, moveSpeed, rotation, rotationSpeed;
    void Start()
    {
        moveSpeed = 5f;
        rotationSpeed = 100f;

    }

    // Update is called once per frame
    void Update()
    {
        // float xDirection = Input.GetAxis("Horizontal");
        // float zDirection = Input.GetAxis("Vertical");
        // Vector3 moveDirection = new Vector3(xDirection, 0.0f,zDirection);
        // transform.position += moveDirection * 0.01f;
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        

    }

    private void LateUpdate()
    {
        transform.Translate(0f,0f,move);
        transform.Rotate(0f,rotation,0f);
    }
}
