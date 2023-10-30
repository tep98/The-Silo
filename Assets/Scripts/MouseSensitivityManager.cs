using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivityManager : MonoBehaviour
{
    [SerializeField] private Slider sensitivitySlider;

    private const string sensitivityKey = "mouseSensitivity";
    private const float defaultSensitivity = 20f;

    private void Start()
    {
        sensitivitySlider.value = PlayerPrefs.GetFloat(sensitivityKey, defaultSensitivity);
    }

    public void ChangeSensitivity()
    {
        float sensitivity = sensitivitySlider.value;
        PlayerPrefs.SetFloat(sensitivityKey, sensitivity);
    }

    public static float GetSavedSensitivity()
    {
        return PlayerPrefs.GetFloat(sensitivityKey, defaultSensitivity);
    }
}
