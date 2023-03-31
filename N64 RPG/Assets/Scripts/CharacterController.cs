using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Animator animator;
    public float speed = 5f; // movement speed

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // Calculate movement speed
        float currentSpeed = direction.magnitude * speed;

        // Rotate the character to face the movement direction
        if (direction.magnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        // Set the animator state based on the character's speed
        animator.SetBool("IsWalking", currentSpeed > 0);

        // Move the character
        transform.position += direction * speed * Time.deltaTime;
    }
}