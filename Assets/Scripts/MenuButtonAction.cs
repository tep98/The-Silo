using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonAction : MonoBehaviour
{
    [SerializeField] private Animator cameraAnim;
    [SerializeField] private GameObject settingMenu;
    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ReturnsFromSettings()
    {
        cameraAnim.SetTrigger("ReturnsFromSettings");
    }

    public void GoToSetting()
    {
        cameraAnim.SetTrigger("GoToSettings");
        settingMenu.SetActive(true);
    }
}
