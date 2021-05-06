using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGoal : MonoBehaviour
{
    public bool goalScored = false;

    public GameObject redCube;

    public GameObject spawnRedCubeLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("GreenCube"))
        {
            goalScored = true;
        } else if (other.gameObject.tag.Equals("RedCube"))
        {
            other.gameObject.transform.position = spawnRedCubeLocation.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("GreenCube"))
        {
            goalScored = false;
        }
    }
}
