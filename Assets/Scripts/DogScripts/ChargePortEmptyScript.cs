using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargePortEmptyScript : MonoBehaviour
{
    public GameObject halfFullChargePort;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Battery"))
        {
            Debug.Log("You added a battery!");
            Destroy(other.gameObject);
            Instantiate(halfFullChargePort, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
