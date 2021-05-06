using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGoalType : MonoBehaviour
{

    public GameObject currentGoal;
    public GameObject nextGoal;
    public GameObject wire1;
    public GameObject wire2;

    private float timeToCheckWires = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckWires());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CheckWires()
    {
        yield return new WaitForSeconds(timeToCheckWires);

        if (!wire1.GetComponent<NorGateWire>().solved && !wire2.GetComponent<nandGateWire>().solved)
        {
            nextGoal.SetActive(true);
            currentGoal.SetActive(false);
        }
        if (currentGoal.activeSelf)
        {
            StartCoroutine(CheckWires());
        }
        
    }
}
