using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPickup : MonoBehaviour
{
    private bool playerNearby = false;
    [SerializeField] private GameObject playerCard;

    private void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            PickUpCard();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }

    private void PickUpCard()
    {
        if (playerCard)
        {
            playerCard.SetActive(true);
        }
        Destroy(gameObject);
    }
}