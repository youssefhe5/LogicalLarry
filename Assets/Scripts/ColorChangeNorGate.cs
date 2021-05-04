using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeNorGate : MonoBehaviour
{

    public NorGateWire norGateWire;
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
        if (norGateWire.solved)
        {
            this.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material = green;
            wireActivated = true;
        } else
        {
            this.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material = red;
        }
    }
}
