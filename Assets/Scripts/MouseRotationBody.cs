using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotationBody : MonoBehaviour
{

    public float XSensitivity = 2f;
    private float yaw;
    private bool canRotate = true;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            canRotate = false;
        }
        else if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            canRotate = true;

        }

        if (canRotate)
        {
            yaw += XSensitivity * Input.GetAxis("Mouse X");
            transform.eulerAngles = new Vector3(0f, yaw, 0f);
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
