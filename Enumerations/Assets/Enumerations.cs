using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour 
{	
	enum Direction {North= 2, East= 10, South= 12, West= 20};
	
	void Start()
	{
		Direction myDirection;
		myDirection = Direction.North;
		myDirection = ReverseDirection (myDirection);
	}
	Direction ReverseDirection (Direction dir)
		{
			if(dir==Direction.North)
				dir= Direction.South;
			return dir;
		}
	}
}
