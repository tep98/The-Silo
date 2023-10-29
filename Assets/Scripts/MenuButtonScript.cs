using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuButtonScript : MonoBehaviour
{
    [SerializeField] private UnityEvent mouseClickAction = new UnityEvent();
    [SerializeField] private GameObject button;

    [SerializeField] private Animator anim;

    private void Start()
    {
        button = this.gameObject;
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            anim.SetBool("isHovered", true);

            if (Input.GetMouseButtonDown(0))
            {
                mouseClickAction.Invoke();
            }
        } 
        else
        {
            anim.SetBool("isHovered", false);
        }
    }
}
