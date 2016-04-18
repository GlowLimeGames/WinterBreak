using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform goal;
	public Transform player;
	public NavMeshAgent agent;
	public AudioSource playerNoise;
	public bool chasePlayer;
	float minDistance;
	float visionDistance;
	float countDown = 10.0f;
	public bool hitSomething;
	public Transform enemy;
	public Vector3 pauseposition;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		enemy = GameObject.FindGameObjectWithTag ("Enemy").transform;
		agent = GetComponent<NavMeshAgent>();
		playerNoise = player.GetComponent<AudioSource>();
		chasePlayer = false;
		minDistance = 5;
		visionDistance = 200;
		agent.speed = 30.0f;
		hitSomething = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (hitSomething) {
			print ("hitsomething");
		}
		if(!chasePlayer && hitSomething) {
			//wait then set to true
			enemy.position = pauseposition;
			countDown -= Time.deltaTime;
			if(countDown < 0){
				hitSomething = false;
				countDown = 10.0f;
			}
			print (countDown);
		}if(!hitSomething){
			print ("still chasing");
			if (playerNoise.isPlaying && CloseToPlayer ())
				chasePlayer = true;

			if (inFieldOfView ())
				chasePlayer = true;
			if (chasePlayer)
				agent.destination = player.position;
			else {
				NavMeshPath path;
				//agent.SetPath(
			}
		

	}

	}	
	bool CloseToPlayer(){
		Vector3 distance = player.position - this.transform.position;
		if (distance.magnitude < minDistance)
			return true;
		return false;
	}

	bool inFieldOfView(){
		Vector3 distance = player.position - this.transform.position;
		if (distance.magnitude > visionDistance)
			return false;
		Vector3 enemyToPlayer = player.position - this.transform.position;
		Vector3 enemyForward = this.transform.forward;

		float temp = Vector3.Angle (enemyToPlayer, enemyForward);
		if (temp < 45)
			return true;
		
		return false;
	}
}
	