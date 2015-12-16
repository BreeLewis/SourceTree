using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour 
{
	void OnTriggerEnter(Collider hit)
	{
	 if(hit.tag == "KillZone")
	 {
	  Destroy(this.gameObject);
	 }
	}
	
}
