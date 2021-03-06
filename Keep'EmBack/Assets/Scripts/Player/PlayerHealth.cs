﻿using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
		
		public Slider healthSlider;                                 // Reference to the UI's health bar.
		public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
	    public AudioClip deathClip;                        
		public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
		public Color flashColor = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
		
		
    	Animator anim;                                              // Reference to the Animator component.
		RaftMove playerMovement;                             	 	// Reference to the player's movement
		bool isDead;                                                // Whether the player is dead.
		bool damaged;                                               // True when the player gets damaged.
		
		
		void Awake ()
		{
			// Setting up the references.
			anim = GetComponent <Animator> ();
			playerMovement = GetComponent <RaftMove> ();
			
		}
		
		
		void Update ()
		{
			// If the player has just been damaged...
			if(damaged)
			{
				// ... set the colour of the damageImage to the flash colour.
				damageImage.color = flashColor;
			}
			// Otherwise...
			else
			{
				// ... transition the colour back to clear.
				damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
			}
			
			// Reset the damaged flag.
			damaged = false;
		}
		
		
		public void TakeDamage (int amount)
		{
			// Set the damaged flag so the screen will flash.
			damaged = true;
			
			// Reduce the current health by the damage amount.
			StaticVars.Health -= amount;
			
			// Set the health bar's value to the current health.
			healthSlider.value = StaticVars.Health;
			
			// If the player has lost all it's health and the death flag hasn't been set yet...
			if(StaticVars.Health <= 0 && !isDead)
			{
				// ... it should die.
				Death ();
			}
		}
		
		
		void Death ()
		{
			// Set the death flag so this function won't be called again.
			isDead = true;
			
			// Turn off the movement 
			playerMovement.enabled = false;

		}       
}
