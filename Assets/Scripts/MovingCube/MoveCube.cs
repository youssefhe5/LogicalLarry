using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    [SerializeField]
    private float timeToSwitchMovment = 2f;
    private bool moveRight = true;
    [SerializeField]
    private float movementSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeBlockDirection());
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        } else
        {
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        }
    }

    IEnumerator ChangeBlockDirection()
    {
        yield return new WaitForSeconds(timeToSwitchMovment);
        if (moveRight)
        {
            moveRight = false;
        } else
        {
            moveRight = true;
        }
        StartCoroutine(ChangeBlockDirection());
        
    }
}
