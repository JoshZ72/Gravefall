using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private int health = 50;

    private int MAX_HEALTH = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //Damage(10); 
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(10);
        }
    }



    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }


    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }



    public void Damage(int amount)
    {

        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Can not have negatve Damage");
        }

        this.health -= amount;
        StartCoroutine(VisualIndicator(Color.red));

        if (health <= 0)
        {
            Die();
        }
    }


    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Can not have negatve healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;
        StartCoroutine(VisualIndicator(Color.green));

        if (wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }


    }

    private void Die()
    {

        if (tag == "Player")
        {
            SceneManager.LoadScene("Gameover");
            
        }
        else
        {
            Debug.Log("You Died");
            Destroy(gameObject);
        }
        

        
    }
    
     
}


