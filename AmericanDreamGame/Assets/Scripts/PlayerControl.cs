using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joystickButton = FindObjectOfType<JoystickButton>();

        if (joystick == null || joystickButton == null)
        {
            Application.Quit(500);
        }
    }

    private void Update()
    {
        if (!jumpInput && joystickButton.IsPressed)
        {
            jumpInput = true;
        }
    }

    private void FixedUpdate()
    {
        animator.SetBool("Grounded", isGrounded);

        DirectUpdate();

        wasGrounded = isGrounded;
        jumpInput = false;
    }

    private void DirectUpdate()
    {
        var y = joystick.Horizontal;

        var cameraTransform = Camera.main.transform;

        currentX = 0;
        currentY = Mathf.Lerp(currentY, y, Time.deltaTime * interpolation);

        var direction = cameraTransform.forward * currentX + cameraTransform.right * currentY;
        var directionLength = direction.magnitude;
        direction.y = 0;
        direction.z = 0;
        direction = direction.normalized * directionLength;

        if (direction != Vector3.zero)
        {
            currentDirection = Vector3.Slerp(currentDirection, direction, Time.deltaTime * interpolation);
            transform.rotation = Quaternion.LookRotation(currentDirection);
            var vec = currentDirection * moveSpeed * Time.deltaTime;
            vec.z = 0;
            transform.position += vec;

            animator.SetFloat("MoveSpeed", directionLength);
        }

        JumpingAndLanding();
    }

    private void JumpingAndLanding()
    {
        bool jumpCooldownOver = Time.time - jumpTimeStamp >= minJumpInterval;

        if (jumpCooldownOver && isGrounded && jumpInput)
        {
            jumpTimeStamp = Time.time;
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (!wasGrounded && isGrounded)
        {
            animator.SetTrigger("Land");
        }

        if (!isGrounded && wasGrounded)
        {
            animator.SetTrigger("Jump");
        }
    }

    private void Awake()
    {
        if (!animator)
        {
            gameObject.GetComponent<Animator>();
        }

        if (!rigidBody)
        {
            gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint[] contactPoints = collision.contacts;

        for (var i = 0; i < contactPoints.Length; i++)
        {
            if (Vector3.Dot(contactPoints[i].normal, Vector3.up) > 0.5f)
            {
                if (!collisions.Contains(collision.collider))
                {
                    collisions.Add(collision.collider);
                }

                isGrounded = true;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        ContactPoint[] contactPoints = collision.contacts;

        bool validSurfaceNormal = false;

        for (var i = 0; i < contactPoints.Length; i++)
        {
            if (Vector3.Dot(contactPoints[i].normal, Vector3.up) > 0.5f)
            {
                validSurfaceNormal = true;
                break;
            }
        }

        if (validSurfaceNormal)
        {
            isGrounded = true;

            if (!collisions.Contains(collision.collider))
            {
                collisions.Add(collision.collider);
            }
        }
        else
        {
            if (collisions.Contains(collision.collider))
            {
                collisions.Remove(collision.collider);
            }

            if (collisions.Count == 0)
            {
                isGrounded = false;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collisions.Contains(collision.collider))
        {
            collisions.Remove(collision.collider);
        }

        if (collisions.Count == 0)
        {
            isGrounded = false;
        }
    }

    [SerializeField] private float moveSpeed = 2;
    [SerializeField] private float jumpForce = 4;

    [SerializeField] private Animator animator = null;
    [SerializeField] private Rigidbody rigidBody = null;

    private float currentX;
    private float currentY;

    private const float interpolation = 10;

    private bool wasGrounded;
    private Vector3 currentDirection = Vector3.zero;

    private float jumpTimeStamp = 0;
    private float minJumpInterval = 0.25f;
    private bool jumpInput = false;

    private bool isGrounded;

    private List<Collider> collisions = new List<Collider>();

    private Joystick joystick;
    private JoystickButton joystickButton;
}