using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour 
{
		public Transform player;
		
		// Tells camera to follow player
		void Start () 
		{
			player = GameObject.FindGameObjectWithTag ("Player").transform;
		}
		
		// How the camera should move
		void Update () 
		{
			transform.position = new Vector3 (player.position.x + 0, player.position.y + 5.5f, player.position.z + -45);
		}
}