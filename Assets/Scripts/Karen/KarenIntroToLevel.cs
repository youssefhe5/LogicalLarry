using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarenIntroToLevel : MonoBehaviour
{
    
    public AudioClip[] clips;


    private AudioSource source;
    private float timeToStartKarenAudio = 1f;
    private float timeToContinueTalking = 20f;
    private float timeToDumbAsPredecessors = 8f;
    private float timeToGuessWellFindOut = 5f;
    private float timeToEnterLevel = 5f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(StartKarenAudio());
    }


    IEnumerator StartKarenAudio()
    {
        yield return new WaitForSeconds(timeToStartKarenAudio);
        source.clip = clips[0];
        source.Play();
        StartCoroutine(TalkAboutKarenModel());
    }

    IEnumerator TalkAboutKarenModel()
    {
        yield return new WaitForSeconds(timeToContinueTalking);
        source.clip = clips[1];
        source.Play();
        StartCoroutine(DumbAsPredecssors());
    }

    IEnumerator DumbAsPredecssors()
    {
        yield return new WaitForSeconds(timeToDumbAsPredecessors);
        source.clip = clips[2];
        source.Play();
        StartCoroutine(GuessWellFindOut());
    }

    IEnumerator GuessWellFindOut()
    {
        yield return new WaitForSeconds(timeToGuessWellFindOut);
        source.clip = clips[3];
        source.Play();
        StartCoroutine(EnterFirstLevel());
    }

    IEnumerator EnterFirstLevel()
    {
        yield return new WaitForSeconds(timeToEnterLevel);
        SceneManager.LoadScene("Level 1");
    }
}
