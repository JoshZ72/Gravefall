using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public GameObject DropPrefab;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        Instantiate(DropPrefab).transform.position = transform.position;
        Destroy(gameObject); 
    }
}
