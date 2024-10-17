using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private float playerSpeed = 2.0f;
    private float jumpSpeed = 3.0f;
    private float turnSpeed = 2.5f;
    private bool grounded;
    public LayerMask ground;

    private PlayerInput playerInput;
    private InputAction moveInput;
    private InputAction jumpInput;
    private Rigidbody rb;

    public Transform orien;
    Vector3 moveDir;
    
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        moveInput = playerInput.actions["Move"];
        jumpInput = playerInput.actions["Jump"];
    }

    
    void Update()
    {
        Vector2 readInput = moveInput.ReadValue<Vector2>();
        moveDir = orien.forward * readInput.x + orien.right * readInput.y;

        rb.AddForce(moveDir.normalized * playerSpeed, ForceMode.Force);
    }

    void FixedUpdate()
    {
        
    }
}
