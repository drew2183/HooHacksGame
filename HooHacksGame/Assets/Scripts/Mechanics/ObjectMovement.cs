using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
	//adjust this to change speed
	public float speed = 5f;
	//adjust this to change how high it goes
	public float height = 0.5f;

	public GameObject target;
	 
	void Update() {
	        //get the objects current position and put it in a variable so we can access it later with less code
	        Vector3 pos = target.transform.position;
	        //calculate what the new Y position will be
	        float newY = Mathf.Sin(Time.time * speed);
	        //set the object's Y to the new calculated Y
	        target.transform.position = new Vector3(pos.x, newY, pos.z) * height;
	}
}