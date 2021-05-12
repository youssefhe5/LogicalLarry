using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchOutForLava : MonoBehaviour
{
    public AudioClip clip;

    private AudioSource source;
    private float timeToDestroy = 4f;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            source.clip = clip;
            source.Play();
            StartCoroutine(DeleteObject());
            GetComponent<BoxCollider>().enabled = false;
        }
        
    }

    IEnumerator DeleteObject()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(this.gameObject);
    }
}
