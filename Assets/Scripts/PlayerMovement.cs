using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController charController;

    public float playerSpeed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 4f;

    [SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;

    Vector2 currDirection = Vector2.zero;
    Vector2 currDirectionVelocity = Vector2.zero;

    private float velocityY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    void UpdateMovement()
    {
        Vector2 targetDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDirection.Normalize();

        currDirection = Vector2.SmoothDamp(currDirection, targetDirection, ref currDirectionVelocity, moveSmoothTime);

        if (charController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocityY = jumpHeight;
            }
        } else
        {
            Debug.Log("Not Grounded");
        }

        

        velocityY += gravity * Time.deltaTime;


        Vector3 velocity = (transform.forward * currDirection.y + transform.right * currDirection.x) * playerSpeed;

        velocity.y = velocityY;

        charController.Move(velocity * Time.deltaTime);
    }
}
