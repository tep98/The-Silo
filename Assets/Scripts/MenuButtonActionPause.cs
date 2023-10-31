using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonActionPause : MonoBehaviour
{
    [SerializeField] private GameObject settingMenu;
    [SerializeField] private GameObject pauseMenu;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            // if (Input.GetKeyDown(KeyCode.Tab))
            // {
            //     Time.timeScale = 1.0f;
            //     pauseMenu.SetActive(false);
            //     Cursor.lockState = CursorLockMode.None;
            //     Cursor.visible = false;
            // }
        }
    }

    public void GoToSettingPause()
    {
        settingMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void ReturnPause()
    {
        settingMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
    }

    public void Continue()
    {
        Time.timeScale = 1.0f;
        settingMenu.SetActive(false);
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
