using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryToFixHim : MonoBehaviour
{

    public AudioClip clip;

    private AudioSource source;
    private float timeToDestroy = 5f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerExit(Collider other)
    {
        source.clip = clip;
        source.Play();
        StartCoroutine(DestroyThis());
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(this.gameObject);
    }
}
