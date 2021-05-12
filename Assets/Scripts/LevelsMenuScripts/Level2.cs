using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    public GameObject level2;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Level 2"))
        {
            level2.SetActive(false);
        }
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
