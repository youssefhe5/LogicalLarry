using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{

    public float timeToHideScreen = 15f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyScreen());
    }

    IEnumerator DestroyScreen()
    {
        yield return new WaitForSeconds(timeToHideScreen);

        this.gameObject.SetActive(false);
    }
}
