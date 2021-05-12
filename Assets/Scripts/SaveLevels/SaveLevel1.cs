using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Level 1", "Level 1");
        Time.timeScale = 1;
    }
}
