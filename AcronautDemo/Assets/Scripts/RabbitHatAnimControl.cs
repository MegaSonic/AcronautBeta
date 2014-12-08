using UnityEngine;
using System.Collections;

public class RabbitHatAnimControl : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.parent.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		animator.SetTrigger ("Hide");
	}

	void OnTriggerExit2D(Collider2D coll){
		animator.SetTrigger ("Show");
	}

}
