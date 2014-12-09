using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public const int JUMP = 0;
	public const int DOUBLE_JUMP = 1;
	public const int DASH = 2;
	public const int WALL_SLIDE = 3;
	public const int TRAMPOLINE = 4;
	public const int BUMPER = 5;
	public const int PICKUP = 6;
	public const int HOVER = 7;
	public const int SPOTLIGHT = 8;
	public const int MONKEY = 9;
	public const int RHINO = 10;
	public const int ELEPHANT = 11;
	public const int HURT = 12;
	public const int BALLOON = 13;
	public const int CANNON = 14;
	public const int OTHER = 100;

	public AudioClip[] jumpSounds = new AudioClip[1];
	public AudioClip[] doubleJumpSounds = new AudioClip[1];
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
	public AudioClip[] hurtSounds = new AudioClip[1];
	public AudioClip[] balloonSounds = new AudioClip[1];
	public AudioClip[] cannonSounds = new AudioClip[1];

	public AudioSource[] audioSources = new AudioSource[1];

	private System.Random randy;
	private AudioSource source;
	private bool oneTwo = false;

	// play a random clip from the array

	public void play(int soundType) {
		int sourceNum = 0;

		while (audioSources[sourceNum].isPlaying) {
			sourceNum++;
			if (sourceNum >= audioSources.Length) return;
		}

		int i = 0;

		switch (soundType) {
		case JUMP:
			i = randy.Next (jumpSounds.Length);
			if (i == 0) oneTwo = true;
			audioSources[sourceNum].clip = jumpSounds [i];
			break;
		case DOUBLE_JUMP:
			if (oneTwo) {
				audioSources[sourceNum].clip = doubleJumpSounds[0];
				oneTwo = false;
			}
			else {
				i = randy.Next (doubleJumpSounds.Length);
				audioSources[sourceNum].clip = doubleJumpSounds[i];
			}
			break;
		case DASH:
			i = randy.Next (dashSounds.Length);
			audioSources[sourceNum].clip = dashSounds[i];
			break;
		case WALL_SLIDE:
			i = randy.Next (wallslideSounds.Length);
			audioSources[sourceNum].clip = wallslideSounds[i];
			break;
		case TRAMPOLINE:
			i = randy.Next (trampolineSounds.Length);
			audioSources[sourceNum].clip = trampolineSounds[i];
			break;
		case BUMPER:
			i = randy.Next (bumperSounds.Length);
			audioSources[sourceNum].clip = bumperSounds[i];
			break;
		case PICKUP:
			i = randy.Next (pickupSounds.Length);
			audioSources[sourceNum].clip = pickupSounds[i];
			break;
		case HOVER:
			i = randy.Next (hoverSounds.Length);
			audioSources[sourceNum].clip = hoverSounds[i];
			break;
		case SPOTLIGHT:
			i = randy.Next (spotlightSounds.Length);
			audioSources[sourceNum].clip = spotlightSounds[i];
			break;
		case MONKEY:
			i = randy.Next(monkeySounds.Length);
			audioSources[sourceNum].clip = monkeySounds[i];
			break;
		case RHINO:
			i = randy.Next(rhinoSounds.Length);
			audioSources[sourceNum].clip = rhinoSounds[i];
			break;
		case ELEPHANT:
			i = randy.Next (elephantSounds.Length);
			audioSources[sourceNum].clip = elephantSounds[i];
			break;
		case HURT:
			i = randy.Next (hurtSounds.Length);
			audioSources[sourceNum].clip = hurtSounds[i];
			break;
		case BALLOON:
			i = randy.Next (balloonSounds.Length);
			audioSources[sourceNum].clip = balloonSounds[i];
			break;
		case CANNON:
			i = randy.Next (cannonSounds.Length);
			audioSources[sourceNum].clip = cannonSounds[i];
			break;
		default:
			i = randy.Next(voiceSounds.Length);
			audioSources[sourceNum].clip = voiceSounds[i];
			break;
		}

		audioSources[sourceNum].Play();
	}


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
