using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawn : MonoBehaviour
{
    [SerializeField] private GameObject levelcard;
    public GameObject[] spawnPoint;
    private int rand;
    private void Start()
    {
        rand = Random.Range(0, spawnPoint.Length);
        Instantiate(levelcard, spawnPoint[rand].transform.position, Quaternion.identity);
    }
}
