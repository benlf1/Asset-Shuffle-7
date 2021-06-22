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

    void FixedUpdate()
    {
        movementInput = GetMovementInput();
        if (movementInput != Vector3.zero)
            movement.Fail(body, movementInput);     // Remove
    }

    private Vector3 GetMovementInput() =>
        new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
}
