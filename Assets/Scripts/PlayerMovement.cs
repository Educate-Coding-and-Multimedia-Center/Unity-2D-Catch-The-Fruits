using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	public float speed = 10f;
	public float minX = -1.9f;
	public float maxX = 1.9f;

	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxisRaw("Horizontal");

		Vector2 temp = transform.position;
		
		if (horizontalInput > 0)
		{
			temp.x += speed * Time.deltaTime;
		}
		else if (horizontalInput < 0)
		{
			temp.x -= speed * Time.deltaTime;
		}

		// Bounds
		if (temp.x > maxX)
		{
			temp.x = maxX;
		}
		else if (temp.x < minX)
		{
			temp.x = minX;
		}

		transform.position = temp;
	}


} // class