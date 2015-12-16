using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
public GameObject[] players;
public int[] myIntArray = {4,8,6,9,3};
void Start()
{
players = GameObject.FindGameObjectsWithTag ("Player");
for (int i=0; i< players.Length; i++)
 {
	Debug.Log ("Player number" +i+ "is named" +players[i].name);
 }
 
  myIntArray[0]=4;
  myIntArray[1]=6;
  myIntArray[2]=8;
  
 
}	
	 
}