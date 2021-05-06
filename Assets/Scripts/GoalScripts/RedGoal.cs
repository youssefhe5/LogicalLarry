using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGoal : MonoBehaviour
{
    public bool goalScored = false;

    public GameObject greenCube;

    public GameObject spawnGreenCubeLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("RedCube"))
        {
            goalScored = true;
        } else if (other.gameObject.tag.Equals("GreenCube"))
        {
            other.gameObject.transform.position = spawnGreenCubeLocation.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("RedCube"))
        {
            goalScored = false;
        }
    }
}
