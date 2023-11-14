using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSpawnpoints : MonoBehaviour
{
    [SerializeField] private int index;
    [SerializeField] private GameObject spawnPointObj;
    private AdRestart adRestart;

    private void Start()
    {
        adRestart = spawnPointObj.GetComponent<AdRestart>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            adRestart.GetPoint(index);
        }
    }
}
