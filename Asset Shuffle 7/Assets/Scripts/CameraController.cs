﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Tutorial from https://youtu.be/_QajrabyTJc
*/
public class CameraController : MonoBehaviour 
{
    public float mouseSensitivity = 300f;
    public Transform playerBody;

    float xRotation = 0f;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

	void Update () {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = -Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // xRotation -= mouseY;
        // xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(new Vector3(mouseY, mouseX, 0f));
	}

}
