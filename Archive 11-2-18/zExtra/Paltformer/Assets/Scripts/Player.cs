using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    float jump = 8;
    float speed = 8;
    int jumpcount = 2;

    Vector3 velocity = new Vector3(0, 0, 0);

    private SpriteRenderer spriterenderer;

    Rigidbody2D rbody;
    private Sprite Square;
    [SerializeField]
    private Sprite Penguinz;
    [SerializeField]
    private Sprite Penguinz2;
    [SerializeField]
    private GameObject feet;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        if (spriterenderer.sprite == null)
        {
            spriterenderer.sprite = Penguinz;
        }
    }

    void Update()
    {
        velocity = rbody.velocity;

        if (jumpcount > 0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                velocity[1] = jump;
                AudioManager.Instance.PlayOneShot(SoundEffect.Woosh);
                jumpcount--;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            changethedamnsprite();
            rbody.GetComponent<Rigidbody2D>().gravityScale = .6f;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            changethedamnspriteback();
            rbody.GetComponent<Rigidbody2D>().gravityScale = 1.9f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameManager.Instance.myPlayer = this;
        }

        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -8f, 8f), Mathf.Clamp(velocity.y, -8f, 8f), 0);

    }
    
    void changethedamnsprite()
    {
        spriterenderer.sprite = Penguinz2;
    }

    void changethedamnspriteback()
    {
        spriterenderer.sprite = Penguinz;
    }
    
    public void OnTriggerEnter2D(Collider2D feet)
    {
        if (feet.gameObject.CompareTag("Ground"))
        {
            jumpcount = 2;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("bad"))
        {
            SceneManager.LoadScene("Level1");
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Level2");
        }
    }

}
