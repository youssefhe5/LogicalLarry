using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCutscene : MonoBehaviour
{

    public AudioClip clip;

    private AudioSource source;
    private float timeToBeginTalking = 2f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(StartTalking());
    }

    IEnumerator StartTalking()
    {
        yield return new WaitForSeconds(timeToBeginTalking);
        source.clip = clip;
        source.Play();
        StartCoroutine(GoToMainMenu());
    }

    IEnumerator GoToMainMenu()
    {
        yield return new WaitForSeconds(27f);
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenu");
    }
}
