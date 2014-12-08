using UnityEngine;
using System.Collections;

public class Bounce_Platform : MonoBehaviour {

	private PlayerController pc;
	private SpriteRenderer sprite;
	private Animator animator;

	public float bounceMultiplier;
	public float minBounce;
	
	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
	
	}

	// Reverse the player's vertical velocity, and multiply it by the bounce multiplier
	void OnCollisionEnter2D(Collision2D coll){
		pc.RefreshAirMoves();
		pc.gravityVelocity = 0f; // reset gravity, to get a little extra bounce
		pc.vertVelocity *= bounceMultiplier * -1;
		if (pc.vertVelocity < minBounce)
			pc.vertVelocity = minBounce;
		animator.SetTrigger ("Bounce");
	}
}
