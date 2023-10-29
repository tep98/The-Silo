using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private Transform[] spawnPoint;

    [SerializeField] private int lotOfEnemy;

    [SerializeField] private GameObject cutScene;
    [SerializeField] private GameObject player;

    private int rand;
    private int randPosition;
    private int iterationCounter = 0;
    private int[] previousRandPositions = new int[100];

    private GameObject[] enemyObjects;


    private void OnTriggerExit(Collider other)
    {
        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject one in enemyObjects)
        {
            Destroy(one);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        while (iterationCounter < lotOfEnemy)
        {
            rand = Random.Range(0, enemyPrefab.Length);
            randPosition = Random.Range(0, spawnPoint.Length);

            if (previousRandPositions.Contains(randPosition))
            {
                continue;
            }

            previousRandPositions[iterationCounter] = randPosition;
            iterationCounter++;

            Instantiate(enemyPrefab[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
        }

        iterationCounter = 0;
    }

    public void CatchPlayer()
    {
        Debug.Log("He is catched!");
        player.SetActive(false);
        cutScene.SetActive(true);
        CutsceneManager.Instance.StartCutscene("DeadAnimation");


        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject one in enemyObjects)
        {
            Destroy(one);
        }
    }

    
}
