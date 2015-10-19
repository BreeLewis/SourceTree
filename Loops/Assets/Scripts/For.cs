using UnityEngine;
using System.Collections;

public class For : MonoBehaviour 
{
int enemies = 3;
	void Start () 
	{
	 	for (int i = 0; i < enemies; i++)
		 {
			 Debug.Log ("Creating enemy number: " + i);
	 	 }	
	}
}