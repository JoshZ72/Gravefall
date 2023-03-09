using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 3f;

    Rigidbody2D myRigbody;
    BoxCollider2D myBoxCollidor;

    [SerializeField]
    private int damage = 10;
    [SerializeField]
    private float speed = 1.5f;

    [SerializeField]
    private Enemy data;

    private GameObject player;

    void Start()
    {
        myRigbody = GetComponent<Rigidbody2D>();
        myBoxCollidor = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        if(IsFacingRight())
        {
            myRigbody.velocity = new Vector2(moveSpeed, 0f);
        } else
        {
            myRigbody.velocity = new Vector2(-moveSpeed, 0f);
        }
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigbody.velocity.x)), transform.localScale.y);

        
            if (collision.CompareTag("Player"))
            {
                if (collision.GetComponent<Health>() != null)
                {
                    collision.GetComponent<Health>().Damage(damage);
                    this.GetComponent<Health>().Damage(100);
                }
            }

        
    }



}
