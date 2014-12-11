using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	public static Music instance = null;
	public AudioClip[] newMusic;
	public AudioSource musicPlayer;

	private int musicTrack = 0;

	private bool fadeOut = false;
	private bool fadeIn = false;

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
		if (fadeOut) {
			musicPlayer.volume -= Time.deltaTime;
			if (musicPlayer.volume <= 0) {
				fadeOut = false;
				musicPlayer.volume = 0;
				musicPlayer.Pause();
			}
		}
		else if (fadeIn) {
			musicPlayer.volume += Time.deltaTime;
			if (musicPlayer.volume >= 1) {
				fadeIn = false;
				musicPlayer.volume = 1;
			}
		}
	}

	void OnLevelWasLoaded() {
		if (Application.loadedLevelName == "mainMenu") return;
		musicPlayer.clip = newMusic[musicTrack];
		musicPlayer.Play();
		musicTrack++;
		if (musicTrack >= newMusic.Length) musicTrack = 0;
	}

	public static void FadeOutMusic() {
		if (instance != null)
			instance.fadeOut = true;
	}

	public static void FadeInMusic() {
		if (instance != null) {
			instance.musicPlayer.Play ();
			instance.fadeIn = true;
		}
	}
}
