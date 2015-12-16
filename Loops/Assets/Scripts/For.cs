using UnityEngine;
using System.Collections;

public class For : MonoBehaviour 
{
int numEnemies = 3;
	void Start () 
	{
		for(int i=0; i<numEnemies; i++)
		{
			Debug.Log ("Creating enemy number:" +i);
		}			
	}
}