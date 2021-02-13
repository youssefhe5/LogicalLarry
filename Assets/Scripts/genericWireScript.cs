using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericWireScript : MonoBehaviour
{

    public andGateWire andGateWire;
    public nandGateWire nandGateWire;
    public Material red;
    public Material green;
    public GameObject[] wires;

    [SerializeField]
    private List<andGateWire> andGateWires = new List<andGateWire>();
    [SerializeField]
    private List<nandGateWire> nandGateWires = new List<nandGateWire>();



    // Awake is called before the game starts
    void Awake()
    {
        this.GetComponent<Renderer>().material = andGateWire.GetComponent<Renderer>().material;
    }

    private void Start()
    {


        for (int i = 0; i < wires.Length; i++)
        {
            if (wires[i].name.Equals("AndGateWire"))
            {
                andGateWires.Add(wires[i].GetComponent<andGateWire>());
                Debug.Log("Wire " + i + " is an andGateWire!");
            } else if (wires[i].name.Equals("NandGateWire"))
            {
                nandGateWires.Add(wires[i].GetComponent<nandGateWire>());
                Debug.Log("Wire " + i + " is a nandGateWire!");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Renderer>().material = andGateWire.GetComponent<Renderer>().material;
    }
}
