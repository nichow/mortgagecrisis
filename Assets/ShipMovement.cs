using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipMovement : MonoBehaviour
{
    public float _thrust; //make private outside of testing
    private Rigidbody2D _rb;

	// Use this for initialization
	void Start ()
	{
	    _rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var direction = Input.GetAxis("Horizontal");
	    if (direction > 0)
	    {
            transform.Rotate(Vector3.back * 2);
	    }
	    if (direction < 0)
	    {
            transform.Rotate(Vector3.forward * 2);
	    }
	}

    void FixedUpdate()
    {
        if (Input.GetButton("Thrust"))
        {
            _rb.AddForce(transform.up * _thrust * Time.fixedDeltaTime);
        }
    }
}
