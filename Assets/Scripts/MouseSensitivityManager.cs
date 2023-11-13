using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivityManager : MonoBehaviour
{
    [SerializeField] private Slider sensitivitySlider;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("mouseSensitivity"))
        {
            PlayerPrefs.SetFloat("mouseSensitivity", 20f);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeSensitivity()
    {
        CameraController.globalSensitivity = sensitivitySlider.value;
        Save();
    }

    private void Load()
    {
        sensitivitySlider.value = PlayerPrefs.GetFloat("mouseSensitivity");
        CameraController.globalSensitivity = sensitivitySlider.value;
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("mouseSensitivity", sensitivitySlider.value);
    }
}

