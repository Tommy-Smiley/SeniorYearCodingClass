using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject Player;
    Vector3 goalVector = new Vector3();
    float hspeed = 2f;
    float vspeed = 1.2f;

	void Start ()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,-10);
	}
	

	void Update ()
    {
        goalVector = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
        goalVector += new Vector3(Player.GetComponent<Rigidbody2D>().velocity.x, Player.GetComponent<Rigidbody2D>().velocity.y,0);

        Vector3 velocity = goalVector - transform.position;

        transform.position += new Vector3(velocity.x * Time.deltaTime * hspeed, velocity.y * Time.deltaTime * vspeed,0);
    }
}
