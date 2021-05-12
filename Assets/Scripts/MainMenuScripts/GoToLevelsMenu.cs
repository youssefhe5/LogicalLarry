using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelsMenu : MonoBehaviour
{
    public void LevelsMenu()
    {
        SceneManager.LoadScene("LevelsMenu");
    }
}
