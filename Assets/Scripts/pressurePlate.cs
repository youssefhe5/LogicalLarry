using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public Material green;
    public Material red;
    public GameObject player;
    public Animator animator;
    public bool pressed = false;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        this.GetComponent<Renderer>().material = red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            animator.SetTrigger("DownTrigger");
            this.GetComponent<Renderer>().material = green;
            pressed = true;
        } else if (other.gameObject.tag.Equals("Dog"))
        {
            animator.SetTrigger("DownTrigger");
            this.GetComponent<Renderer>().material = green;
            pressed = true;
        } else if (other.gameObject.tag.Equals("Cube"))
        {
            animator.SetTrigger("DownTrigger");
            this.GetComponent<Renderer>().material = green;
            pressed = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            animator.SetTrigger("UpTrigger");
            this.GetComponent<Renderer>().material = red;
            pressed = false;
        } else if (other.gameObject.tag.Equals("Dog"))
        {
            animator.SetTrigger("UpTrigger");
            this.GetComponent<Renderer>().material = red;
            pressed = false;
        }  else if (other.gameObject.tag.Equals("Cube"))
        {
            animator.SetTrigger("UpTrigger");
            this.GetComponent<Renderer>().material = red;
            pressed = false;
        }
    }
}
