using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControls : MonoBehaviour
{
    public GameObject controls;

    public void Controls()
    {
        controls.SetActive(true);
    }
}
