using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushButton : MonoBehaviour
{

    public Animator animator;
    public GameObject gameObject;
    public int variable = 0;
    public bool canPush = false;


    private int pushCount = 1;

    private void Start()
    {
        animator = GetComponent<Animator>();
        gameObject = GetComponent<GameObject>();
    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0) && canPush)
        {
            animator.SetTrigger("Trigger");
            canPush = false;
            pushCount++;
            if (pushCount % 2 == 0)
            {
                variable = 1;
                
            } else
            {
                variable = 0;
            }
            
            Debug.Log("Mouse pressed on Red Button");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canPush = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canPush = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canPush = false;
        }
    }
}
