using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public Animator attackanim;

    public float MeleeAttackRadius;

    public float MeleeAttackRange;

    public Vector3 Attackoffset;

    private Vector3 attackDir;

    public bool isMeleeAttacking;
     
    private float meleeTimer;

    int TotalMeleeTime = 2;

    

    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(Input.GetKey(KeyCode.Space));
            attackanim.Play("attack");

            
        }
        if (meleeTimer > TotalMeleeTime)
        {
            meleeTimer = 0;
            isMeleeAttacking = false;
            attackanim.Play("attack");
        }

    }

    

        
   
    
       
}
