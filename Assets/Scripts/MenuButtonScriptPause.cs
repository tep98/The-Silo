using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuButtonScriptPause : MonoBehaviour
{
    [SerializeField] private UnityEvent mouseClickAction = new UnityEvent();
    [SerializeField] private GameObject button;

    private void Start()
    {
        button = this.gameObject;
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mouseClickAction.Invoke();
            }
        } 
    }
}
