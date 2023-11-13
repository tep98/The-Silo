using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdRestart : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void AdRelive();


    public GameObject[] playerSpawnPoints;
    
    public void GetPoint(int point)
    {

    }
}
