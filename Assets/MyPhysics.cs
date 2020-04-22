using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysics : MonoBehaviour
{
    public Monster monster;
    // Start is called before the first frame update
    void Start()
    {
        monster = GetComponent<Monster>();
        monster.position = transform.localPosition;
       // eulerRotation.y = 180;
    }

    public Vector3 eulerRotation = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        //update speed
      //  if (Utils.ApproximatelyEqual(monster.speed, monster.desiredSpeed))
      //  { ;  }
        if (monster.speed < monster.desiredSpeed)
        {
            Debug.Log("SPEED LESS THAN DESIRED");
            monster.speed = monster.speed + monster.acceleration * Time.deltaTime;
        }
        else if (monster.speed > monster.desiredSpeed)
        {
            Debug.Log("SPEED MORE THAN DESIRED");
            monster.speed = monster.speed - monster.acceleration * Time.deltaTime;
        }
        monster.speed = Utils.Clamp(monster.speed, monster.minSpeed, monster.maxSpeed);

        //update heading
        if (Utils.ApproximatelyEqual(monster.heading, monster.desiredHeading))
        {
            ;
        }
        else if (Utils.AngleDiffPosNeg(monster.desiredHeading, monster.heading) > 0)
        {
            monster.heading += monster.turnRate * Time.deltaTime;
        }
        else if (Utils.AngleDiffPosNeg(monster.desiredHeading, monster.heading) < 0)
        {
            monster.heading -= monster.turnRate * Time.deltaTime;
        }
        monster.heading = Utils.Degrees360(monster.heading);
        //
        monster.velocity.x = Mathf.Sin(monster.heading * Mathf.Deg2Rad) * monster.speed;
        monster.velocity.y = 0;
        monster.velocity.z = Mathf.Cos(monster.heading * Mathf.Deg2Rad) * monster.speed;

        monster.position = monster.position + monster.velocity * Time.deltaTime;
        transform.localPosition = monster.position;

        eulerRotation.y = monster.heading;
        transform.localEulerAngles = eulerRotation;
    }
}
