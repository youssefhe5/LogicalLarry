using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    public andGateWire andGateWire;
    public Material red;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material = red;
    }

    // Update is called once per frame
    void Update()
    {
        if (andGateWire.solved)
        {
            this.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material = green;
        } else
        {
            this.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material = red;
        }
    }
}
