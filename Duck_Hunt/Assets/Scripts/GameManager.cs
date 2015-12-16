using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
  public delegate void DuckDel();
  public static DuckDel OnSpawnDuck;
  public static DuckDel OnDuckShot;
  public static DuckDel OnDuckDeath;
  public static DuckDel OnDuckFlyAway;
  public static DuckDel OnDuckMiss;
	
	
	
	
}
