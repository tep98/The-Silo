using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdRestart : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void AdRelive();

    public int spawnIndex = 0;
    public GameObject[] playerSpawnPoints;
    [SerializeField] private AudioSource music;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject restartUI;
    
    public void Start()
    {
        player.transform.position = playerSpawnPoints[spawnIndex].transform.position;
    }

    public void GetPoint(int point)
    {
        if (spawnIndex < point)
        {
            spawnIndex = point;
        }
    }

    public void ShowAdButton()
    {
        AdRelive();
        Time.timeScale = 0;
        music.volume = 0f;
    }

    public void RelivePlayer()
    {
        Time.timeScale = 1;
        music.volume = 1f;
        restartUI.SetActive(false);
        Spawn();
    }

    private void Spawn()
    {
        if (spawnIndex==1 || spawnIndex==6 || spawnIndex==11)
        {
            Progress.Instance.PlayerInfo.Spawnpoint = spawnIndex;
            Progress.Instance.Save();
        }
        player.transform.position = playerSpawnPoints[spawnIndex].transform.position;
    }

    public void GoToStart()
    {
        if (spawnIndex==1 || spawnIndex==6 || spawnIndex==11)
        {
            Progress.Instance.PlayerInfo.Spawnpoint = spawnIndex;
            Progress.Instance.Save();
        }
        player.transform.position = playerSpawnPoints[0].transform.position;
    }
}
