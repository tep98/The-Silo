using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float sensitivity = 50f;
    [SerializeField] private Transform playerBody;
    [SerializeField] private float maxYEngle;

    private float xRotation = 0f;

    private void Start()
    {
        LoadSensitivity();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void LoadSensitivity()
    {
        sensitivity = PlayerPrefs.GetFloat("mouseSensitivity", 20f);
    }

}
