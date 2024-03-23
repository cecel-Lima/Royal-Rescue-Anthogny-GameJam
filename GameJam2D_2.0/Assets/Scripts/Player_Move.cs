using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Player_Move : MonoBehaviour
{
    AudioManager audioManager;
    Animator animator;
    private Rigidbody2D rb;
    public float speed = 5;
    public bool movement;
    public TextMeshProUGUI itensUI, healthUI;
    public int keyTotal = 0;
    public int healthTotal = 1;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("Idle_Player", true);
        animator.SetBool("Run_1", false);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerDeath();
        itensUI.text = "x" + keyTotal.ToString();
        healthUI.text = "x" + healthTotal.ToString();

    }

    private void Move(Vector3 direction)
    {
        Vector3 destination = transform.position + direction;
    }

    void PlayerMove()
    {
        Vector2 position = transform.position;

        if (Input.anyKey != true)
        {
            animator.SetBool("Idle_Player", true);
            animator.SetBool("Run_1", false);
        }

        else
        {
            animator.SetBool("Idle_Player", false);
        }

        if (Input.GetKey("w"))
        {
            position.y += speed * Time.deltaTime;
            animator.SetBool("Run_1", true);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            Move(Vector3.up);


        }

        if (Input.GetKey("s"))
        {
            position.y -= speed * Time.deltaTime;
            animator.SetBool("Run_1", true);
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            Move(Vector3.down);
        }

        if (Input.GetKey("d"))
        {
            position.x += speed * Time.deltaTime;
            animator.SetBool("Run_1", true);
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
            Move(Vector3.right);
        }

        if (Input.GetKey("a"))
        {
            position.x -= speed * Time.deltaTime;
            animator.SetBool("Run_1", true);
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            Move(Vector3.left);
        }

        transform.position = position;
    }

    void PlayerDeath()
    {
        if (healthTotal <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Key"))
        {
            keyTotal += 1;
            Destroy(col.gameObject);
            audioManager.PlaySFX(audioManager.item);
        }

        if (col.gameObject.CompareTag("Cage") && keyTotal == 1)
        {
            SceneManager.LoadScene("Victory_Screen", LoadSceneMode.Single);
        }

        if (col.gameObject.CompareTag("Potion"))
        {
            healthTotal += 1;
            Destroy(col.gameObject);
            audioManager.PlaySFX(audioManager.item);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            healthTotal -= 1;
        }
    }

    public void MoveRight()
    {
        Vector2 position = transform.position;

        position.x += speed * Time.deltaTime;
        animator.SetBool("Run_1", true);
        transform.rotation = Quaternion.Euler(0f, 0f, 270f);
        Move(Vector3.right);

        transform.position = position;
    }

    public void MoveLeft()
    {
        Vector2 position = transform.position;

        position.x -= speed * Time.deltaTime;
        animator.SetBool("Run_1", true);
        transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        Move(Vector3.left);

        transform.position = position;
    }

    public void MoveUp()
    {
        Vector2 position = transform.position;

        position.y += speed * Time.deltaTime;
        animator.SetBool("Run_1", true);
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        Move(Vector3.up);

        transform.position = position;
    }

    public void MoveDown()
    {
        Vector2 position = transform.position;

        position.y -= speed * Time.deltaTime;
        animator.SetBool("Run_1", true);
        transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        Move(Vector3.down);

        transform.position = position;
    }
}
