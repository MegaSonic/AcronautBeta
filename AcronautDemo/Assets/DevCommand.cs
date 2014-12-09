using UnityEngine;
using System.Collections;

public class DevCommand : MonoBehaviour {
	
	public static DevCommand instance = null;

	private float restartTimer = 2.5f;

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
		if (Input.GetKey(KeyCode.R)) {
			restartTimer -= Time.deltaTime;
			if (restartTimer < 0f) {
				foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
					Destroy(o);
				}
				Application.LoadLevel("intro");
			}
		}
	}
}
