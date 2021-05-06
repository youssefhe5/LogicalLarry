using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{

    public GameObject item;
    public GameObject hand;
    public float distance;
    public float throwPower = 10;

    private bool rightPressed = false;


    // Start is called before the first frame update
    void Start()
    {
        item.gameObject.GetComponent<Rigidbody>().useGravity = true;
        if (hand == null)
        {
            hand = GameObject.Find("Hand");
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (rightPressed)
            {
                
                OnMouseUp();
                item.transform.position = hand.transform.position;
                item.GetComponent<Rigidbody>().AddForce(hand.transform.forward * throwPower, ForceMode.Impulse);
            }
        }
        
    }

    private void OnMouseDown()
    {
        rightPressed = true;
        
        if (Mathf.Abs(hand.transform.position.x - item.transform.position.x) < distance)
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            
            item.transform.position = hand.transform.position;          
            item.transform.rotation = hand.transform.rotation;
            item.transform.parent = hand.transform.parent;
            item.GetComponent<Rigidbody>().freezeRotation = true;

            


        }
        
    }

    private void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        rightPressed = false;
        item.GetComponent<Rigidbody>().freezeRotation = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Environment") && gameObject.GetComponent<BoxCollider>())
        {
            OnMouseUp();
        } else if (other.gameObject.tag.Equals("Door") && gameObject.GetComponent<BoxCollider>())
        {
            OnMouseUp();
        } else if (other.gameObject.tag.Equals("Goal") && gameObject.GetComponent<BoxCollider>())
        {
            OnMouseUp();
        }
    }

}
