using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{

    public GameObject level3;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Level 3"))
        {
            level3.SetActive(false);
        }
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
