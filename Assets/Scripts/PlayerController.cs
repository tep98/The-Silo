using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHeight;
    private CharacterController controller;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private Animator cameraAnim;

    private bool isOnGround;
 
    Vector3 velocity;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        isOnGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);

        if(isOnGround && velocity.y <0)
        {
            velocity.y = -2f;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput!=0 || verticalInput != 0)
        {
            cameraAnim.SetBool("isRun", true);
        }
        else
        {
            cameraAnim.SetBool("isRun", false);
        }

        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        /*Jump*/
        /*if(Input.GetButtonDown("Jump") && isOnGround)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }*/

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
