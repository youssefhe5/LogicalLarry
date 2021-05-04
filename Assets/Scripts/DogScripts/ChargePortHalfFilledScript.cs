using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargePortHalfFilledScript : MonoBehaviour
{
    public GameObject filledChargePort;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Battery"))
        {
            Debug.Log("You added a battery!");
            Destroy(other.gameObject);
            Instantiate(filledChargePort, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }


}
