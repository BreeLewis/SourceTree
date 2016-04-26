using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour {
		
		public MeshRenderer meshRenderer;
		public List<Transform> spawnPoints;
		public int health = 1;
		private int reHealth; 

	//	delegate void SharkAttack (); 
	//	SharkAttack = LiveDead;


		void AddToSpawnPointsList (Transform _spawnPoint) 
		{
			spawnPoints.Add (_spawnPoint);
		}

		void Start ()
		{
			reHealth = health; 
		}
		
		IEnumerator Spawn ()
		{
			reHealth = health;
			yield return new WaitForSeconds (1);
			meshRenderer.enabled = true;
			int randomSpawnPointNum = UnityEngine.Random.Range (0, spawnPoints.Count - 1);
			transform.position = spawnPoints[randomSpawnPointNum].transform.position;
			print (randomSpawnPointNum); 
		}
		
		void StartSpawn ()
		{
			meshRenderer.enabled = false;
			StartCoroutine (Spawn ());
		}
		
	//Kill the shark on a click of the mouse.
		void OnMouseDown ()
		{

			print ("Dead Shark");
			
			if (reHealth > 0)
				reHealth --; 
			else
				StartSpawn ();
			
			
		}
}
