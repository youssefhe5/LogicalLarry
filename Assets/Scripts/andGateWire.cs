using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andGateWire : MonoBehaviour
{
    public Material green;
    public Material red;
    public PushButton rightButton;
    public PushButton leftButton;
    public bool solved;



    // Awake is called before the game is loaded
    void Awake()
    {
        this.GetComponent<Renderer>().material = red;
        solved = false;
    }

    // Update is called once per frame
    void Update()
    {

        if ((rightButton.variable ==1) && (leftButton.variable == 1))
        {
            this.GetComponent<Renderer>().material = green;
            solved = true;
        } else
        {
            this.GetComponent<Renderer>().material = red;
            solved = false;
        }
        
    }
}
