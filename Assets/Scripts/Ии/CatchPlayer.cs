using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchPlayer : MonoBehaviour
{
    private Spawner spawnManager;

    private void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnManager.CatchPlayer();
        }
    }
}
