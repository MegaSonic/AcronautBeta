using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour {

	public Text text;
	private float timer = 0.8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0f) {
			if (text.color == Color.white)
				text.color = Color.black;
			else text.color = Color.white;
			timer = 1f;
		}
	}
}
