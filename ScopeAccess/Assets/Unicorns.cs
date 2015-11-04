using UnityEngine;
using System.Collections;

public class Unicorns : MonoBehaviour 
{
	private int white = 2;
	private int black = 4;
	private Dragons myOtherClass;
	public int herd= 8;
	private int grey = 4;
	private int brown = 4;
	public int death;
	
	private void Unicorn () 
	{
	 herd = grey + brown;
	 Debug.Log ("population:" +herd);
	}
	void start()
	{
	 myOtherClass = new Dragons();
	 myOtherClass.food= 2;
	 myOtherClass.Consume(herd);
	}

 	public void Eaten (int noGrass) 
	{
	 int decline;
	 decline = death * herd * noGrass;
	 Debug.Log ("Death in the herd:" + decline);
	}
}
