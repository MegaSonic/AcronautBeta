using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Reload() {
		Debug.Log ("Hello?");
		Application.LoadLevel(Application.loadedLevel);
	}
}
