using UnityEngine;
using System.Collections;

public class SpawnTree : MonoBehaviour {

	public GameObject tree;
	public Transform[] spawnPoints;
	public GameObject floor;
//	float minX, maxX, minY, maxY;

	public int numOfTrees = 0;

	//		minX = -400;//gameObject.GetComponent<Collider> ().bounds.min.x;
	//		maxX = 400;//gameObject.GetComponent<Collider> ().bounds.max.x;
	//		minY = -400;//gameObject.GetComponent<Collider> ().bounds.min.y;
	//		maxY = 400;//gameObject.GetComponent<Collider> ().bounds.max.y;

	// Use this for initialization
	void Start () {
		numOfTrees = Random.Range (10, 15); // make 5-10 trees

		for (int i = 0; i < numOfTrees; i++) {
			Vector3 spawn = new Vector3 (Random.Range(-170f, -45f), 0.5f, Random.Range(-100f, 200f));
			Instantiate (tree, spawn, Quaternion.identity);
		}

//		for(int i =0 ; i<300; i++){
//			Vector3 spawn = new Vector3 (Random.Range (minX, maxX), .5f, Random.Range (minY, maxY));
//
//			tree.GetComponent<Renderer> ().material.color = Color.green;
//			Instantiate (tree, spawn, Quaternion.Euler(new Vector3(0,0,0)));
//		}
	}

	// Update is called once per frame
//	void Update () {
//
//	}

//	void OnCollisionEnter(Collision col){
//		Destroy (this.gameObject);
//	}
}

