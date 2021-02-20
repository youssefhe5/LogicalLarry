using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public Material green;
    public Material red;
    public GameObject player;
    public Animator animator;
    

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
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            animator.SetTrigger("UpTrigger");
            this.GetComponent<Renderer>().material = red;
        }
    }
}
