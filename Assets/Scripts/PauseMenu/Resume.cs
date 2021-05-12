using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject mouseRotationHead;
    public GameObject mouseRotationBody;

    public void BackToPlay()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        mouseRotationHead.GetComponent<MouseRotatonHead>().paused = false;
        mouseRotationBody.GetComponent<MouseRotationBody>().paused = false;
    }
}
