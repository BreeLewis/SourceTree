using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour 
{
	RaycastHit hit;
	
	private int bulletAmt;
	public int maxBullets;
	
	void Start()
	{
	 GameManager.OnSpawnDuck+- ResetBullets;
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
		 bulletAmt--;
		  if (bulletAmt <=0)
		  {
		   GameManager.OnDuckMiss();
		  }
		  Vector3 mousePos= Input.mousePosition;
		  mousePos.z=Camera.main.transform.position.z;
		  
		  if(Physics.Raycast (Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
		  {
		   if (hit.transform.tag == "duck")
		   {
		    // Use the getcomponent in hit to get the duck health script. Usint that call the killduck function in duck health script.
		   }
		  }
		}
	}

 public void ResetBullets()
 {
  bulletAmt= maxBullets;
 }
}
