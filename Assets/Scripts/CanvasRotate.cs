using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasRotate : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject Camera;
    private float detectionRadius = 10f;
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        canvas.SetActive(false);
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, playerTransform.position) <= detectionRadius)
        {
            canvas.SetActive(true);
            if (canvas.transform.rotation != Camera.transform.rotation)
            {
                canvas.transform.rotation = Camera.transform.rotation;
            }
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
