using UnityEngine;
using System.Collections;

public class ScreenSettings : MonoBehaviour {

	private float baseAspect = 640.0f / 360.0f;

	// Use this for initialization
	void Start () {
		float currAspect = 1.0f * Screen.width / Screen.height;

		Camera.main.projectionMatrix = Matrix4x4.Scale(new Vector3(currAspect / baseAspect, 1.0f, 1.0f)) * Camera.main.projectionMatrix;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
