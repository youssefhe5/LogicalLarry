using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotatonHead : MonoBehaviour
{

    public float XSensitivity = 2f;
    public float YSensitivity = 2f;
    public float minimumY = -20f;
    public float maximumY = 20f;
    public float minimumX = -90f;
    public float maximumX = 90f;
    public Transform playerCamera = null;
    public GameObject head;
    public bool paused = false;

    private float yaw;
    private float pitch;
    private bool altPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            pitch -= YSensitivity * Input.GetAxis("Mouse Y");

            pitch = Mathf.Clamp(pitch, minimumY, maximumY);

            playerCamera.localEulerAngles = Vector3.right * pitch;

            if (altPressed == false)
            {
                yaw = 0f;
            }


            if (Input.GetKey(KeyCode.LeftAlt))
            {
                altPressed = true;

                head.transform.localEulerAngles = new Vector3(pitch, yaw, 0f);

                yaw += XSensitivity * Input.GetAxis("Mouse X");

                yaw = Mathf.Clamp(yaw, minimumX, maximumX);

            }
            else if (Input.GetKeyUp(KeyCode.LeftAlt))
            {
                altPressed = false;
            }
            else
            {
                head.transform.localEulerAngles = new Vector3(pitch, 0f, 0f);
            }


            if (Input.GetKeyDown("escape"))
            {
                Cursor.lockState = CursorLockMode.None;
            }

            if (Input.GetMouseButtonDown(0))
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        

        

    }
}
