using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textDisplay : MonoBehaviour
{

    public Text text;
    public GameObject zero;
    public GameObject one;
    public GameObject currentObject;


    public PushButton pushButton;

    // Update is called once per frame
    void Update()
    {
        Vector3 textPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        textPosition.z -= 10;
        text.transform.position = textPosition;
        text.text = pushButton.variable + "";
    }

}
