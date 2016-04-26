using UnityEngine;
using System.Collections;
using System;
public class ThisIsSpawnPoint : MonoBehaviour 
{	
	public static Action<Transform> PassTransformAsSpawnPoint;

	void Start ()
	{
		if (PassTransformAsSpawnPoint != null)
			PassTransformAsSpawnPoint(transform);
	}
}
