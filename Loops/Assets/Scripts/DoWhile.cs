using UnityEngine;
using System.Collections;

public class DoWhile : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		bool shouldContinue = false;
		do
		{
			print ("Hello World");
		}while(shouldContinue == true);
	}
}
