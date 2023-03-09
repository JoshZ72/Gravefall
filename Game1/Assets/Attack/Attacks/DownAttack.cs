using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownAttack : MonoBehaviour
{
    public float attackRange = 1f;
    public LayerMask enemyLayers;
    public Transform attackPoint;


    private GameObject attackArea = default;
    private bool attacking = false;
    private float timetoAttack = 0.25f;
    private float timer = 0f;
    void Start()
    {
        attackArea = transform.GetChild(3).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Attack();
        }

        if (attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timetoAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }

    }

    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
