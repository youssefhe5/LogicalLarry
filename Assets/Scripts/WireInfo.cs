using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireInfo : MonoBehaviour
{

    public Material green;
    public Material red;
    public PushButton button;

    // Start is called before the first frame update
    void Awake()
    {
        if (button.isZero)
        {
            this.GetComponent<Renderer>().material = red;
        } else
        {
            this.GetComponent<Renderer>().material = green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (button.isZero)
        {
            this.GetComponent<Renderer>().material = red;
        }
        else
        {
            this.GetComponent<Renderer>().material = green;
        }
    }
}
