using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarenTutorial : MonoBehaviour
{

    public AudioClip[] karenAudioClips;
    public float timeToDestroyKaren = 24f;
    public GameObject karen;
    public GameObject pauseMenu;

    private AudioSource source;
    private bool playLastClip = false;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = karenAudioClips[0];
        source.Play();
        StartCoroutine(DestroyThis());
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying && !playLastClip)
        {
            source.clip = karenAudioClips[1];
            source.Play();
            playLastClip = true;
        }

        if (playLastClip && !source.isPlaying)
        {
            source.clip = karenAudioClips[2];
            source.Play();
        }
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(timeToDestroyKaren);
        karen.SetActive(true);
        pauseMenu.SetActive(true);
        Destroy(this.gameObject);
    }
}
