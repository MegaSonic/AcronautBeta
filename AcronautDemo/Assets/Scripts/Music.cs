using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	public static Music instance = null;
	public AudioClip[] newMusic;
	public AudioSource musicPlayer;

	private int musicTrack = 0;

	// Use this for initialization
	void Start () {
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		}
		else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLevelWasLoaded() {
		if (Application.loadedLevelName == "mainMenu") return;
		musicPlayer.clip = newMusic[musicTrack];
		musicPlayer.Play();
		musicTrack++;
		if (musicTrack >= newMusic.Length) musicTrack = 0;
	}
}
