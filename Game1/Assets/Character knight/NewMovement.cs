using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{

    [SerializeField] private float speed = 3f;

    private Rigidbody2D body;
    private Vector2 axisMovement; 


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //axisMovement.x = Input.GetAxisRaw("Horizontal");
        //axisMovement.x = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        //Move();
    }

    private void Move()
    {
        //body.velocity = axisMovement.normalized * speed;
        //CheckForFlipping();
    }

    private void CheckForFlipping()
    {

    }
}

