using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour {

	private float waitTimer = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		waitTimer -= Time.deltaTime;

		if ((Input.GetButtonDown("Jump") || Input.GetButtonDown("Pause")) && waitTimer <= 0f) {
			foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
				Destroy(o);
			}
			Application.LoadLevel("intro");
		}
	}
}
