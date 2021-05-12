using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject wire;

    private Animator animator;

    private float secondsToOpenDoor = 2f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wire.GetComponent<ColorChangeAndGate>() != null)
        {
            if (wire.GetComponent<ColorChangeAndGate>().wireActivated)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<ColorChangeOrGate>() != null)
        {
            if (wire.GetComponent<ColorChangeOrGate>().wireActivated)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<ColorChangeNandGate>() != null)
        {
            if (wire.GetComponent<ColorChangeNandGate>().wireActivated)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<ColorChangeNorGate>() != null)
        {
            if (wire.GetComponent<ColorChangeNorGate>().wireActivated)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<pressurePlate>() != null)
        {
            if (wire.GetComponent<pressurePlate>().pressed)
            {
                StartCoroutine(OpenDoorWithPressurePlate());
            }
        } else if (wire.GetComponent<Goal>() != null)
        {
            if (wire.GetComponent<Goal>().goalScored)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<RedGoal>() != null)
        {
            if (wire.GetComponent<RedGoal>().goalScored)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<GreenGoal>() != null)
        {
            if (wire.GetComponent<GreenGoal>().goalScored)
            {
                animator.SetTrigger("OpenDoor");
            }
        } else if (wire.GetComponent<WireCheck>() != null)
        {
            if (wire.GetComponent<WireCheck>().complete)
            {
                animator.SetTrigger("OpenDoor");
            }
        }

    }

    IEnumerator OpenDoorWithPressurePlate()
    {
        yield return new WaitForSeconds(secondsToOpenDoor);
        animator.SetTrigger("OpenDoor");
    }
}
