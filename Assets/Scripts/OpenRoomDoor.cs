using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoomDoor : MonoBehaviour
{

    public GameObject buttonPressed;

    private Animator animator;
    private float secondsToDestroy = 4f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed.GetComponent<pressurePlate>() != null)
        {
            if (buttonPressed.GetComponent<pressurePlate>().pressed)
            {
                animator.SetTrigger("Trigger");
                StartCoroutine(DestroyWall());
            }
        }

        if (buttonPressed.GetComponent<andGateWire>() != null)
        {
            if (buttonPressed.GetComponent<andGateWire>().solved)
            {
                animator.SetTrigger("Trigger");
                StartCoroutine(DestroyWall());
            }
        }
        
    }

    IEnumerator DestroyWall()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        Destroy(this.gameObject);
    }
}
