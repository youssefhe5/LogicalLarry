using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject mouseRotationHead;
    public GameObject mouseRotationBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            mouseRotationHead.GetComponent<MouseRotatonHead>().paused = true;
            mouseRotationBody.GetComponent<MouseRotationBody>().paused = true;
        } else if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            mouseRotationHead.GetComponent<MouseRotatonHead>().paused = false;
            mouseRotationBody.GetComponent<MouseRotationBody>().paused = false;
        }
    }
}
