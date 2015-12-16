using UnityEngine;
using System.Collections;

public class Dragons : MonoBehaviour 
{
	private int ruby = 2;
	public int eat = 2;
	private int gold = 4;
	private int silver =4;
	public int pack = 8;
	public int food;
	private Unicorns myOtherClass;
	
	void Start()
	{
		myOtherClass = new Unicorns();
		myOtherClass.death = 2;
		myOtherClass.Eaten(eat);
	}
	
	public void Consume(int treasure) 
	{
		pack = treasure*food;
		Debug.Log ("pack");
	}
	
	void Update () 
	{
		Debug.Log ("Dragon poplulation:" + pack);
	}
}
