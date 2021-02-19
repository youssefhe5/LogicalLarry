using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nandGateWire : MonoBehaviour
{

    public Material red;
    public Material green;
    public PushButton rightButton;
    public PushButton leftButton;
    public bool solved;


    // Awake is called before the game starts
    void Awake()
    {
        this.GetComponent<Renderer>().material = red;
        solved = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!((rightButton.variable == 1) && (leftButton.variable == 1)))
        {
            solved = true;
            this.GetComponent<Renderer>().material = green;
        } else
        {
            solved = false;
            this.GetComponent<Renderer>().material = red;
        }
    }
}
