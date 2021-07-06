using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Basic controller script for the player
/// </summary>
public class PlayerController : MonoBehaviour
{
    public Rigidbody body;
    public Movement movement;

    private Vector3 movementInput;
    public GameObject cam;

    public GameObject player;
    void FixedUpdate()
    {
        cam.transform.position = this.transform.position;
        movementInput = GetMovementInput();
        if (movementInput != Vector3.zero) {
            Debug.Log(cam.transform.forward);
            float targetAngle =  Mathf.Atan2(movementInput.x, movementInput.z) * Mathf.Rad2Deg;
            Vector3 moveDir = cam.transform.forward;
            // player.transform.Translate(moveDir);
            movement.Fail(body, moveDir);     // Remove
        }
    }

    private Vector3 GetMovementInput() =>
        new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
}
