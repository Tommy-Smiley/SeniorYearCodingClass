using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector3 velocity = new Vector3(0, 0, 0);

    void Start()
    {
        //velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
    }

    void Update()
    {
        
        transform.eulerAngles += new Vector3(0, 5f, 5f);

        transform.position += velocity * Time.deltaTime;
        if (transform.position.x < -1.75f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(-1.75f, transform.position.y, 0);
        }
        if (transform.position.x > 1.75f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(1.75f, transform.position.y, 0);
        }
        if (transform.position.y > 1)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, 1, 0);
        }
        if (transform.position.y < -1)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, -1, 0);
        }
    }
}
