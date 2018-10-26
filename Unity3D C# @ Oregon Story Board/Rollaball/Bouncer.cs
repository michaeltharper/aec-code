using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour 
{
    public float speed = 10;
    public Vector3 direction = new Vector3(0.0f, 1, 0.0f);
    // public Vector3 direction = new Vector3(.43f, 1, .567f);

    float runTime = 0.0f;
    float waitTime = 0.0f;
    float interval = 1.0f;

	// Use this for initialization
	void Start () 
	{ 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((runTime > interval) && (waitTime > interval))
		{
			direction.x = direction.x * -1;
			direction.y = direction.y * -1;
			direction.z = direction.z * -1;
			runTime = 0;
			waitTime = 0;
		}

		if (runTime < interval)
		{
			this.transform.position +=  direction * speed * Time.deltaTime;
			runTime += Time.deltaTime;
		}

		if (runTime > interval)
		{
			waitTime += Time.deltaTime;
		}

	}
}
