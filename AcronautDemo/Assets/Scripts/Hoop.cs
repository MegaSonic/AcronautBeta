using UnityEngine;
using System.Collections;

public class Hoop : MonoBehaviour {
	
	private PlayerController pc;
	private bool gotBurned = false;
	private bool gotReward = false;
	private Level level;

	public float timeReward = 2.5f;


	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		level = GameObject.FindGameObjectWithTag("Level").GetComponent<Level>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		pc.Knockback (-1);	
		gotBurned = true;
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (gotBurned == false && gotReward == false) {
			level.playerTime -= timeReward;
		}
	}
}
