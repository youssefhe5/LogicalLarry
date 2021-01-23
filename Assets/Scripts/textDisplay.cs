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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 textPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        textPosition.z -= 10;
        text.transform.position = textPosition;
        text.text = pushButton.variable + "";

        //TODO: Create a way to display button presses (zero or one) onto logic box
    }

    private void newNumber()
    {
        if (pushButton.variable == 1)
        {

            //GameObject newZero = Instantiate(one, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;

        }
    }
}
