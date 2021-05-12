using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Level 2", "Level 2");
        Time.timeScale = 1;
    }
}
