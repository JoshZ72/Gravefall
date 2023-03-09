using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerattack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;

    private float timeAttack = 0.25f;

    private float timer = 0f;

    public Animator weaponanim;



    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
           
                Debug.Log(Input.GetKey(KeyCode.Space));
                weaponanim.Play("attackanim");
        }

        if(attacking) 
        {
            timer += Time.deltaTime; 
        }
    }
}
