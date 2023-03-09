using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : MonoBehaviour
{
    public float offset;

    public GameObject projectile;
    public Transform shotpoint;

    private float TimeBtwShots;
    public float startTimeBtwShots;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotz + offset);

        if (TimeBtwShots <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(projectile, shotpoint.position, transform.rotation);
                TimeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            TimeBtwShots -= Time.deltaTime; 
        }
    }


}
