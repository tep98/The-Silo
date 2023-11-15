using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StartAdv : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void StartAdBanner();

    [SerializeField] private AudioSource music;
     
    private void Start()
    {
        StartAdBanner();
        Time.timeScale = 0;
        music.volume = 0f;
    }
    

    public void OffPause()
    {
        Time.timeScale = 1;
        music.volume = 1f;
    }
}
