using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject controls;

    public void ReturnToPauseMenu()
    {
        controls.SetActive(false);
    }
}
