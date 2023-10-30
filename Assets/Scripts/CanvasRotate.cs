using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasRotate : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject Camera;
    [SerializeField] private float detectionRadius = 10f;
    [SerializeField] private bool isText = false;
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        if (!isText)
        {
            canvas.SetActive(false);
        }
       
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
            if (!isText)
            {
                canvas.SetActive(false);
            }
        }
    }
}
