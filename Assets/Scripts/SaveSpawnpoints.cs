using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSpawnpoints : MonoBehaviour
{
    [SerializeField] private int index;
    private void OnTriggerEnter(Collider other)
    {
        AdRestart.GetPoint(index)
    }
}
