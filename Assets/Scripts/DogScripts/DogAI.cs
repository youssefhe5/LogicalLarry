using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogAI : MonoBehaviour
{
    public GameObject player;
    public float stoppingDistance = 3f;
    public AudioClip clip;

    private NavMeshAgent agent;
    private Animator animator;
    private AudioSource source;
    [SerializeField]
    private float randomTime = 0f;
    [SerializeField]
    private float randomAmountOfBarks = 2f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        source.clip = clip;
        StartCoroutine(DogBark());
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

    IEnumerator DogBark()
    {
        yield return new WaitForSeconds(randomTime);
        randomTime = Random.Range(5f, 15f);
        
        if (randomAmountOfBarks <= 1)
        {
            source.Play();
        } else if (randomAmountOfBarks <= 2)
        {
            source.Play();
            StartCoroutine(BarkTwice());
        } else if (randomAmountOfBarks <= 3)
        {
            source.Play();
            StartCoroutine(BarkTwice());
            StartCoroutine(BarkThreeTimes());
        }
        randomAmountOfBarks = Random.Range(0f, 3f);

        StartCoroutine(DogBark());
    }

    IEnumerator BarkTwice()
    {
        yield return new WaitForSeconds(0.5f);
        source.Play();
    }

    IEnumerator BarkThreeTimes()
    {
        yield return new WaitForSeconds(1f);
        source.Play();
    }
}
