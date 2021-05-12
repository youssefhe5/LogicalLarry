using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBatteries : MonoBehaviour
{
    public GameObject battery1;
    public GameObject battery2;

    public GameObject deliveryBattery;

    private float timeToShowBatteries = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deliveryBattery.GetComponent<BatteryDeilvery>().enabled)
        {
            StartCoroutine(EnableBatteries());
        }
    }

    IEnumerator EnableBatteries()
    {
        yield return new WaitForSeconds(timeToShowBatteries);
        battery1.SetActive(true);
        battery2.SetActive(true);
        Destroy(this.gameObject);
    }
}
