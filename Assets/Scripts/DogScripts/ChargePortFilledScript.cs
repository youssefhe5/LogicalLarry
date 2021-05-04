using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargePortFilledScript : MonoBehaviour
{
    public GameObject deadDog;

    public GameObject aliveDog;

    private float timeToTurnOnDog = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnOnDog());

        deadDog = GameObject.Find("deadDogFinishedPrefab");
    }


    IEnumerator TurnOnDog()
    {
        yield return new WaitForSeconds(timeToTurnOnDog);
        Destroy(deadDog);
        Instantiate(aliveDog, transform.position + new Vector3(0,0.5f,0), Quaternion.Euler(0,90,0));
        Destroy(this.gameObject);
    }
}
