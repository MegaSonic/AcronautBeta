using UnityEngine;
using System.Collections;

public class DevCommand : MonoBehaviour {
	
	public static DevCommand instance = null;

	private float restartTimer = 2.5f;
	private float skipTimer = 2.5f;
	private float reloadTimer = 2.5f;

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
			if (restartTimer <= 0f) {
				foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
					Destroy(o);
				}
				Application.LoadLevel("intro");
			}
		}

		if (Input.GetKeyUp (KeyCode.R)) {
			restartTimer = 2.5f;
		}

		if (Input.GetKey (KeyCode.S)) {
			skipTimer -= Time.deltaTime;
			if (skipTimer <= 0f) {
				Level level = GameObject.FindGameObjectWithTag("Level").GetComponent<Level>();
				Application.LoadLevel(level.nextLevel);
				skipTimer = 2.5f;
			}
		}

		if (Input.GetKeyUp(KeyCode.S)) {
			skipTimer = 2.5f;
		}

		if (Input.GetKey (KeyCode.L)) {
			reloadTimer -= Time.deltaTime;
			if (reloadTimer <= 0f) {
				reloadTimer = 2.5f;
				Application.LoadLevel(Application.loadedLevel);
			}
		}

		if (Input.GetKeyUp(KeyCode.L)) {
			reloadTimer = 2.5f;
		}
	}
}
