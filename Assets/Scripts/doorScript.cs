using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{

    public Animator animator;
    public andGateWire andGateWire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (andGateWire.solved)
        {
            animator.SetTrigger("Trigger");
        }
    }
}
