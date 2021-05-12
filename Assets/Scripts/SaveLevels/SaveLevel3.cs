using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Level 3", "Level 3");
        Time.timeScale = 1;
    }
}
