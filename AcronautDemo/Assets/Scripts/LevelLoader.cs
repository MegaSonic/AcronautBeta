using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Pause") || Input.GetButtonDown("Jump"))
			Application.LoadLevel("level1");
	}

	public void LoadTest() {
		Application.LoadLevel("proto2");
	}

	public void LoadLevel(string level) {
		Application.LoadLevel (level);
	}
}
