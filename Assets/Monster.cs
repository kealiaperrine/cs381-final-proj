using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject monster;
    public Vector3 position;
    public Vector3 velocity;

    public float speed;
    public float desiredSpeed;
    public float heading;
    public float desiredHeading;

    public float acceleration;
    public float turnRate;
    public float maxSpeed;
    public float minSpeed;

    public float currentHealth;

    //public bool intercepting = false;

    // Start is called before the first frame update
    void Start()
    {
        //currentHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(int damageAmount)
    {
        //Debug.Log(damageAmount);
        Debug.Log(currentHealth);
        currentHealth -= 1;
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
            Player.inst.killCount++;
        }
    }

}
