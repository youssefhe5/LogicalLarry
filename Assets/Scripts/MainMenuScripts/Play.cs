using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void StartGame()
    {
        if (PlayerPrefs.HasKey("Level 3"))
        {
            SceneManager.LoadScene("Level 3");
        } else if (PlayerPrefs.HasKey("Level 2"))
        {
            SceneManager.LoadScene("Level 2");
        } else if (PlayerPrefs.HasKey("Level 1"))
        {
            SceneManager.LoadScene("Level 1");
        } else
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
