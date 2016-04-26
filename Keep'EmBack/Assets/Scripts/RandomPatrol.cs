using UnityEngine;
using System.Collections;

public class RandomPatrol : MonoBehaviour {


	NavMeshAgent enemyAgent;
	public Transform destination;

	// Use this for initialization
	void Start () {
		enemyAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		enemyAgent.destination = destination.position;
	}
}
