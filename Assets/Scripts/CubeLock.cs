using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLock : MonoBehaviour
{

    public GameObject greenCube;
    public GameObject andGateWire;
    public GameObject orGateWire;
    public Material green;

    private float timeToUnlock = 2f;

    // Update is called once per frame
    void Update()
    {
        if (andGateWire.GetComponent<ColorChangeAndGate>().wireActivated && orGateWire.GetComponent<ColorChangeOrGate>().wireActivated)
        {
            this.GetComponent<Renderer>().material = green;
            StartCoroutine(UnLockCube());
        }
    }

    IEnumerator UnLockCube()
    {
        yield return new WaitForSeconds(timeToUnlock);
        Destroy(this.gameObject);
        greenCube.SetActive(true);
    }
}
