using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	
	private PlayerController pc;
	private Animator animator;
	private Animator animatorBack;
	
	public float pauseTime;
	public float launchAngle;
	public float launchForce;

	private float timer;
	private bool inPause = false;
	private float hForce;
	private float vForce;

	private bool isFiring = false;

	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		animator = GetComponent<Animator>();
		animatorBack = transform.FindChild ("cannon back").GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (inPause) {
			if (timer > 0){
				timer -= Time.deltaTime;
			}
			else {
				inPause = false;
				pc.cannonWait = false;

				// launch
				float launchAngRad = launchAngle * Mathf.Deg2Rad;
				hForce = launchForce * Mathf.Cos (launchAngRad);
				vForce = launchForce * Mathf.Sin (launchAngRad);
				pc.horizVelocity = hForce;
				pc.vertVelocity = vForce;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (!isFiring) {
			pc.cannonWait = true;
			pc.transform.position = this.gameObject.transform.position;
			pc.transform.Translate(0.35f, -0.2f, 0f);
			inPause = true;
			timer = pauseTime;
			pc.horizVelocity = 0f;
			pc.vertVelocity = 0f;
			isFiring = true;
			animator.SetTrigger("Rotate");
			animatorBack.SetTrigger("Rotate");
		}
	}

	void OnTriggerExit2D(Collider2D coll) {
		isFiring = false;
	}

}