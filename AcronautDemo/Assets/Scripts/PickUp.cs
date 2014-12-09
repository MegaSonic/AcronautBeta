using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	
	public SpriteRenderer sprite;
	public BoxCollider2D box;
	public float timeSave = 5f;

	Level level;

	// Use this for initialization
	void Start () {
		level = GameObject.FindGameObjectWithTag("Level").GetComponent<Level>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			sprite.enabled = false;
			box.enabled = false;
			level.playerTime -= timeSave;

			SoundManager sm = coll.gameObject.transform.FindChild ("Sound Manager").GetComponent<SoundManager> ();
			sm.play (SoundManager.PICKUP);

		}
		
	}
}
