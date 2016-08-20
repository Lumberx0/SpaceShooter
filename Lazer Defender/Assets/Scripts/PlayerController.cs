using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {

public int speed;
public float minX;
public float maxX;
public float padding = 1f;
public GameObject projectile;
public float projectileSpeed = 20f;


	// Use this for initialization
	void Start () {
	speed = 9;

	float distance = transform.position.z - Camera.main.transform.position.z;

	Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
	Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
	minX = leftMost.x + padding;
	maxX = rightMost.x - padding;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject beam = Instantiate(projectile, transform.position , Quaternion.identity) as GameObject;
			beam.GetComponent<Rigidbody2D>().velocity = new Vector3 (0, projectileSpeed,0);



		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
		} else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

		}
		float newX = Mathf.Clamp (transform.position.x, minX, maxX);
		transform.position = new Vector3(newX, transform.position.y, transform.position.z);
	}


}
