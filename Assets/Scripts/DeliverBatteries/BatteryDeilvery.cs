using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDeilvery : MonoBehaviour
{
    public GameObject andGate;
    public GameObject nandGate;
    public GameObject norGate;
    public GameObject orGate;

    public bool enabled = false;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (andGate.GetComponent<andGateWire>() != null && nandGate.GetComponent<nandGateWire>() != null && norGate.GetComponent<NorGateWire>() != null && orGate.GetComponent<OrGateWire>() != null)
        {
            if (andGate.GetComponent<andGateWire>().solved && nandGate.GetComponent<nandGateWire>().solved && norGate.GetComponent<NorGateWire>().solved && orGate.GetComponent<OrGateWire>().solved)
            {
                animator.SetTrigger("Deliver");
                enabled = true;
            }
        }
    }
}
