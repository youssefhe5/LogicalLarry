using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public bool goalScored = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Cube"))
        {
            goalScored = true;
        } else if (other.gameObject.tag.Equals("RedCube"))
        {
            goalScored = true;
        } else if (other.gameObject.tag.Equals("GreenCube"))
        {
            goalScored = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Cube"))
        {
            goalScored = false;
        } else if (other.gameObject.tag.Equals("RedCube"))
        {
            goalScored = false;
        } else if (other.gameObject.tag.Equals("GreenCube"))
        {
            goalScored = false;
        }
    }
}
