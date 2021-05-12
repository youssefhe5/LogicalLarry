using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireCheck : MonoBehaviour
{

    public GameObject andGateWire;
    public GameObject nandGateWire;
    public GameObject orGateWire;
    public GameObject norGateWire;

    public bool complete = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (andGateWire.GetComponent<andGateWire>() != null && nandGateWire.GetComponent<nandGateWire>() != null && orGateWire.GetComponent<OrGateWire>() != null && norGateWire.GetComponent<NorGateWire>() != null)
        {
            if (andGateWire.GetComponent<andGateWire>().solved && nandGateWire.GetComponent<nandGateWire>().solved && orGateWire.GetComponent<OrGateWire>().solved && norGateWire.GetComponent<NorGateWire>().solved)
            {
                complete = true;
            }
        } else if (nandGateWire.GetComponent<nandGateWire>() != null && norGateWire.GetComponent<NorGateWire>() != null)
        {
            if (nandGateWire.GetComponent<nandGateWire>().solved && norGateWire.GetComponent<NorGateWire>().solved)
            {
                complete = true;
            }
        } else if (andGateWire.GetComponent<andGateWire>() != null)
        {
            if (andGateWire.GetComponent<andGateWire>().solved)
            {
                complete = true;
            }
        }
    }
}
