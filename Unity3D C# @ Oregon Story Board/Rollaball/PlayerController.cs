// Michael Harper - June 2017 - Dev 101  - HW2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCount();
        winText.text = "";
     }

    // FixedUpdate is called just before performing physics calcs.
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
	// if gameObject is a pickup object, deactivate
    	if (other.gameObject.CompareTag("Pick Up"))
    	{	
    		other.gameObject.SetActive(false);
    		count = count + 1;
            setCount();
    	}
    }

    void setCount()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12) winText.text = "Winner Winner\nChicken Dinner";
    }
}