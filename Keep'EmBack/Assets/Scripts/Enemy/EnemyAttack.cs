using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour 
{
	public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
	public int attackDamage = 2;                // The amount of health taken away per attack.
	GameObject player;                          // Reference to the player GameObject.
	PlayerHealth playerHealth;                  // Reference to the player's health.
	EnemyHealth enemyHealthy; 
	bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
	float timer;                                // Timer for counting up to the next attack.


	void Awake ()
	{
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealthy = GetComponent<EnemyHealth>();
	}
	
	
	void OnTriggerEnter (Collider col)
	{
		// If the entering collider is the player...
		if(col.gameObject.tag == "Player")
		{
			Debug.Log ("Attack");
			// ... the player is in range.
			playerInRange = true;
			Attack ();
		}
	}
	
	void OnTriggerExit (Collider ex)
	{
		// If the exiting collider is the player...
		if(ex.gameObject == player)
		{
			// ... the player is no longer in range.
			playerInRange = false;
		}
	}
	
	
	void OnTriggerStay ()
	{
		// Add the time since Update was last called to the timer.
		timer += Time.deltaTime;

		// If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
		if(timer >= timeBetweenAttacks && playerInRange && EnemyHealth.currentHealth> 0)
		{
			// ... attack.
			Attack ();
		}

	}
	void Attack ()
	{
		// Reset the timer.
		timer = 0f;
		
		// If the player has health to lose...
		if(StaticVars.Health > 0)
		{
			// ... damage the player.
			playerHealth.TakeDamage (attackDamage);
		}
	} 
}