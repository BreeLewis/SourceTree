using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
public int intelligence = 5;

void Greet()
	{
		switch (intelligence)
		{
			case 2:
				print ("Watcha want?");
				break;
			case 1:
				print ("Grog Smash!");
				break;
			default:
				print ("No Intelligence Found");
				break;
				
		}
	}	
} 
