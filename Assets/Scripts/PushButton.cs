using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PushButton : MonoBehaviour
{

    public Animator animator;
    public GameObject gameObject;
    public int variable = 0;
    public bool canPush = false;
    public bool isZero;
    public TMP_Text number;
    public Material red;
    public Material green;

    private float time;
    private int pushCount = 0;

    private void Start()
    {
        animator = GetComponent<Animator>();
        gameObject = GetComponent<GameObject>();
        number.text = variable + "";
        if (variable == 0)
        {
            isZero = true;
        } else
        {
            isZero = false;
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0) && canPush && (animator.GetCurrentAnimatorStateInfo(0).IsTag("LeftButtonIdle") || animator.GetCurrentAnimatorStateInfo(0).IsTag("RightButtonIdle")) && time > 0.5f)
        {
            time = 0;
            animator.SetTrigger("Trigger");
            Debug.Log(animator.GetInstanceID());
            canPush = false;
            pushCount++;
            if (isZero)
            {
                variable = 1;
                number.text = variable + "";
                isZero = false;
                this.GetComponent<Renderer>().material = green;

            } else
            {
                
                variable = 0;
                number.text = variable + "";
                isZero = true;
                this.GetComponent<Renderer>().material = red;
            }

            Debug.Log("Mouse pressed on " + this.name +  " button");
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
