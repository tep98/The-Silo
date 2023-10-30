using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardReader : MonoBehaviour
{
    [SerializeField] private UnityEvent buttonClickAction = new UnityEvent();
    [SerializeField] private Animator anim;
    [SerializeField] private Transform player;

    public int readerLevel;

    private float distanceX;
    private float distanceY;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        distanceX = gameObject.GetComponent<Transform>().position.x - player.position.x;
        distanceY = gameObject.GetComponent<Transform>().position.y - player.position.y;

        if (distanceX < 5 && distanceX > -5 && distanceY < 5 && distanceY > -5)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Card playerCard = player.GetComponentInChildren<Card>();
                if (playerCard != null && playerCard.cardLevel == readerLevel)
                {
                    anim.SetTrigger("setOpen");
                    buttonClickAction.Invoke();
                    Destroy(playerCard.gameObject);
                }
            }
        }
    }
}
