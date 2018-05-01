using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipMovement : MonoBehaviour
{
    private float _thrust;   //value that determines how quickly the ship accelerates or decelerates
    private Rigidbody2D _rb; //the rigidbody of the ship for determining physics

	// Use this for initialization
	void Start ()
	{
	    _thrust = 35;
	    _rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var direction = Input.GetAxis("Horizontal");
	    if (direction > 0)
	    {
            transform.Rotate(Vector3.back * 2); //turn ship right
	    }
	    if (direction < 0)
	    {
            transform.Rotate(Vector3.forward * 2); //turn ship left
	    }
	}

    void FixedUpdate()
    {
        if (Input.GetButton("Thrust"))
        {
            _rb.AddForce(transform.up * _thrust * Time.fixedDeltaTime); //accelerate
        }
        else if (Input.GetButton("Brake"))
        {
            _rb.AddForce(-1 * transform.up * _thrust * Time.fixedDeltaTime); //decelerate
        }
    }
}
