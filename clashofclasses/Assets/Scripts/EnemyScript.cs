using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int health;

	// Use this for initialization
	void Start () {
		health = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0) { //if no health left
			Debug.Log("ded"); //debugging is good
			Destroy(this.gameObject); //destroy enemy
		}
	}

	void attackOne () {
		health--; //need to replace with something which will do different health depending on subject or something :/
		Debug.Log ("Ouch! Attack 1. Health: " + health); //debug EVERYTHING
	}

	void attackTwo () {
		health--; //need to replace with something which will do different health depending on subject or something :/
		Debug.Log("Ouch! Attack 2. Health: " + health); //debug EVERYTHING
	}
}
