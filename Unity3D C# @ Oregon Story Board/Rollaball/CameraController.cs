// Michael Harper - June 2017 - Dev 101  - HW2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame, but LateUpdate insures following cameras run their Update() last.
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
