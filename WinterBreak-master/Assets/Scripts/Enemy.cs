using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int attackDamage = 1;

	GameObject player;                          // Reference to the player GameObject.
	float timer;                                // Timer for counting up to the next attack.

	void Awake ()
	{
//		// Setting up the references.
		player = GameObject.FindGameObjectWithTag ("Player");
	}
//
//
//	void Update ()
//	{
//		// Add the time since Update was last called to the timer.
//		timer += Time.deltaTime;
//
//		Attack (); //////
//
////		// If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
////		if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
////		{
////			// ... attack.
////			Attack ();
////		}
//	}
//
//
//	void Attack ()
//	{
//		// Reset the timer.
//		timer = 0f;
//
//		// If the player has health to lose...
//		if(playerHealth.currentHealth > 0)
//		{
//			// ... damage the player.
//			playerHealth.TakeDamage (attackDamage);
//		}
//	}

}
