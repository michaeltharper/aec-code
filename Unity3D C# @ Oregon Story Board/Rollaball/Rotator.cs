// Michael Harper - June 2017 - Dev 101  - HW2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(60,60,60) * Time.deltaTime * 2);
	}
}
