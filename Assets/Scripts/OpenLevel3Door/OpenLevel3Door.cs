using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLevel3Door : MonoBehaviour
{
    public GameObject hand;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("aliveDogFinishedPrefab(Clone)"))
        {
            animator.SetTrigger("OpenDoor");
            hand.transform.localPosition = new Vector3(0,0,3.894f);
        }
    }
}
