using UnityEngine;
using System.Collections;

public class Monkey : MonoBehaviour {
	private PlayerController pc;
	private Animator animator;

	public float pauseTime = 0.25f;

	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		// move player to underneath
		pc.transform.position = this.gameObject.transform.position;

		SoundManager sm = coll.gameObject.transform.FindChild ("Sound Manager").GetComponent<SoundManager> ();
		sm.play (SoundManager.MONKEY); // play player's sound
		
		SoundManager sm2 = transform.FindChild ("Sound Manager").GetComponent<SoundManager> ();
		sm2.play (SoundManager.MONKEY); // play monkey's sound

		pc.isSwinging = true;
		if (pc.isHovering)
			pc.KillHover ();
		pc.swingPauseTimer = pauseTime;
		pc.horizVelocity = 0f;
		pc.vertVelocity = 0f;

		animator.SetTrigger ("Throw");
	}
}
