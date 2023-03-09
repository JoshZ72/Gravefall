using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public Animator playeranim;
    
    public float playerspeed = 5;

    public Vector2 movement;

    private Vector3 Velocity;

    private Rigidbody2D body;


    public string playerTag = "Player";

    public static event Action OnPlayerDeath;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Velocity = Vector3.zero;

        Camera.main.transform.position = new Vector3(transform.position.x,
            transform.position.y,
            transform.position.z - 10);

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(Input.GetKey(KeyCode.W));
            playeranim.Play("playeranim_up");
            transform.position += new Vector3(0, playerspeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playeranim.Play("playeranim_down");
            transform.position += new Vector3(0, -playerspeed * Time.deltaTime, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            playeranim.Play("playeranim_right");
            transform.position += new Vector3(playerspeed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            playeranim.Play("playeranim_left");
            transform.position += new Vector3(-playerspeed * Time.deltaTime, 0, 0);
        }


    }

    
}