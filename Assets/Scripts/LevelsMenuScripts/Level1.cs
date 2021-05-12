using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{

    public GameObject level1;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Level 1"))
        {
            level1.SetActive(false);
        }
    }

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
}
