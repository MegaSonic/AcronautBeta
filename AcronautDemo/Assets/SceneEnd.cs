using UnityEngine;
using System.Collections;

public class SceneEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToMainMenu() {
		Application.LoadLevel("mainMenu");
	}
}
