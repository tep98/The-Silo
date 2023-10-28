using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchPlayer : MonoBehaviour
{
    [SerializeField] private GameObject cutScene;
    [SerializeField] private GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("He is catched!");
            player.SetActive(false);
            cutScene.SetActive(true);
            CutsceneManager.Instance.StartCutscene("DeadAnimation");
            gameObject.SetActive(false);
        }
    }
}
