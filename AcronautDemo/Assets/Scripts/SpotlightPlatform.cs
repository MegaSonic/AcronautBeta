using UnityEngine;
using System.Collections;

public class SpotlightPlatform : MonoBehaviour {
	
	private PlayerController pc;
	private Animator animator;
	
	public float pauseTime; // amount of pause time on first contact (for animations, sound, etc to play)
	public float spotlightTime; // amount of time player will keep new abilities
	
	private bool used = false; // indicated whether this platform has already been used
	private bool isPaused = false;
	private bool inSpotlight = false;
	private float timer;

	private AudioSource music;

	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		music = this.gameObject.GetComponent<AudioSource>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (used == true && music.isPlaying == false) {

		}

		if (isPaused) {
			if (timer > 0)
				timer -= Time.deltaTime;
			else { // begin spotlight mode!
				isPaused = false;
				inSpotlight = true;
				pc.paused = false;
				pc.inSpotlight = true;
				timer = spotlightTime;
			}
		}

		else if (inSpotlight) {
			if (music.isPlaying == false) {
				inSpotlight = false;
				pc.inSpotlight = false;
				Music.FadeInMusic();
			}
			/*if (timer > 0)
				timer -= Time.deltaTime;
			else { // end spotlight mode
				inSpotlight = false;
				pc.inSpotlight = false;
				Music.FadeInMusic();
			}*/
		}
	}
	
	// Reverse the player's vertical velocity, and multiply it by the bounce multiplier
	void OnTriggerEnter2D(Collider2D coll){
		if (!used) {
			// start the pause timer
			isPaused = true;
			timer = pauseTime;

			// pause the player
			pc.paused = true;

			used = true;

			// SoundManager sm = coll.gameObject.transform.FindChild ("Sound Manager").GetComponent<SoundManager> ();
			// sm.play (SoundManager.SPOTLIGHT);
			Music.FadeOutMusic();
			music.Play();


			animator.SetTrigger("Activate");
		}
	}
}
