using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Animator>().SetTrigger("OpenDoor");
    }
}
