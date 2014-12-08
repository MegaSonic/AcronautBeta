using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip[] jumpSounds = new AudioClip[1];
	public AudioClip[] dashSounds = new AudioClip[1];
	public AudioClip[] wallslideSounds = new AudioClip[1];
	public AudioClip[] trampolineSounds = new AudioClip[1];
	public AudioClip[] bumperSounds = new AudioClip[1];
	public AudioClip[] pickupSounds = new AudioClip[1];
	public AudioClip[] hoverSounds = new AudioClip[1];
	public AudioClip[] spotlightSounds = new AudioClip[1];
	public AudioClip[] monkeySounds = new AudioClip[1];
	public AudioClip[] rhinoSounds = new AudioClip[1];
	public AudioClip[] elephantSounds = new AudioClip[1];
	public AudioClip[] voiceSounds = new AudioClip[1];

	private System.Random randy;
	private AudioSource source;

	// play a random clip from the array

	public void playJump() {
		int i = randy.Next (jumpSounds.Length);
		source.clip = jumpSounds [i];
		source.Play ();
	}



	// Use this for initialization
	void Start () {
		randy = new System.Random ();
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
