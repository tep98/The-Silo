using UnityEngine;
using System.Collections;

public class AI_Ray : MonoBehaviour {

    private Transform Player;
    private UnityEngine.AI.NavMeshAgent NMA;



	private void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        NMA = (UnityEngine.AI.NavMeshAgent)this.GetComponent("NavMeshAgent");
	}
	
	
	private void FixedUpdate () {
        NMA.SetDestination(Player.position);
	}
}
