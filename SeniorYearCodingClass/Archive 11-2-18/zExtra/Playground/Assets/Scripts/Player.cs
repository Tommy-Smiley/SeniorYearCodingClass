using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    GameObject ballprefab;

    Vector3 velocity = new Vector3(0, 0, 0);
    float timer = 0f;
    float overalltimer=.5f;


    void Start()
    {

    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > overalltimer)
        {
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            timer = 0;
        }

        Vector3 velocity = new Vector3(0, 0, 0);
        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z + 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
          
        velocity.Normalize();
        transform.position += velocity * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballprefab);
            newBall.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
            newBall.GetComponent<Transform>().localScale = new Vector3(Random.Range(0f, 5f), Random.Range(0f, 5f), 1);
            newBall.transform.position = transform.position;
            newBall.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z);
        }
    }
    void movementWASD()
    {
        velocity = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 1)
            {
                velocity += Vector3.up;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -1.75)
            {
                velocity += Vector3.left;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -1)
            {
                velocity += Vector3.down;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 1.75)
            {
                velocity += Vector3.right;
            }
        }
    }
    public Vector3 LookAtDirection(float eulerAngleZ)
    {
        return new Vector3(Mathf.Cos(eulerAngleZ * Mathf.Deg2Rad), Mathf.Sin(eulerAngleZ * Mathf.Deg2Rad), 0);
    }
  
}
