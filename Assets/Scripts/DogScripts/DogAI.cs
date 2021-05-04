using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogAI : MonoBehaviour
{
    public GameObject player;
    public float stoppingDistance = 3f;

    private NavMeshAgent agent;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {

            if (agent.remainingDistance < stoppingDistance)
            {
                animator.SetTrigger("StopRunning");
            } else
            {
                animator.SetTrigger("Run");
            }
            agent.destination = player.transform.position;
            
        }
        

    }
}
