using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This is where we declare the variuables
    public float speed = 2.0f;
    public float sprintSpeed = 5.0f;
    public float gravity = 3.5f;

    // Private variables
    private float currentSpeed = 0;
    private float fallSpeed = 0;
    private CharacterController controller;
    private Vector3 motion;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // when the game starts the player is stationary
        motion = Vector3.zero;

        if (controller.isGrounded == true)
        {
            //Do stuff here
            fallSpeed = -gravity * Time.deltaTime;

            // check the key that is pressed
            if (Input.GetKeyDown(KeyCode.LeftShift) == true)
            {
                if (currentSpeed != sprintSpeed)
                {
                    currentSpeed = sprintSpeed;
                }
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift) == true)
            {
                if (currentSpeed != speed)
                {
                    currentSpeed = speed;
                }
            }
        }
        else
        {
            fallSpeed -= gravity * Time.deltaTime;
        }

        ApplyMovement();
    }

    void ApplyMovement()
    {
        motion += transform.forward * Input.GetAxisRaw("Vertical") * currentSpeed * Time.deltaTime;
        motion += transform.right * Input.GetAxisRaw("Horizontal") * currentSpeed * Time.deltaTime;
        motion.y += fallSpeed;

        if (controller.enabled)
        {
            controller.Move(motion);
        }
    }

}
