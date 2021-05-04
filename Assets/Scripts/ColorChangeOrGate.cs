using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOrGate : MonoBehaviour
{

    public OrGateWire OrGateWire;
    public Material red;
    public Material green;

    public bool wireActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material = red;
    }

    // Update is called once per frame
    void Update()
    {
        if (OrGateWire.solved)
        {
            this.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material = green;
            wireActivated = true;
        } else
        {
            this.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material = red;
        }
    }
}
