using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericWireScript : MonoBehaviour
{

    public andGateWire andGateWire;
    public Material red;
    public Material green;


    // Awake is called before the game starts
    void Start()
    {
        this.GetComponent<Renderer>().material = andGateWire.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Renderer>().material = andGateWire.GetComponent<Renderer>().material;
    }
}
