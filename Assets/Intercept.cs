using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intercept : Command
{
    public Player player;
    public Vector3 movePosition;

    // Start is called before the first frame update
    public Intercept(Monster mon, Player play) : base(mon)
    {
        player = play;
        movePosition = play.position;
    }

    public override void Init()
    {
        Debug.Log("Intercepting");
    }

    public override void Tick()
    {
        //Debug.Log("INTERCEPT TICK");
        float dh = ComputePredictiveDH(/*offset maybe?*/);
        monster.desiredHeading = dh;
        monster.desiredSpeed = monster.maxSpeed;
        Debug.Log(monster.desiredSpeed);
        Debug.Log(monster.speed);
    }

    public float doneDistanceSq = 3.0f;
    public override bool IsDone()
    {
        return diff.sqrMagnitude < doneDistanceSq;
    }

    public override void Stop()
    {
        //Debug.Log("DONE");
        //monster.desiredSpeed = 0;
        //player.desiredSpeed = 0; maybe? rather than offset 
        // I dont think i want everything else he has
    }



    /// <summary>
    /// helper funciotns
    /// </summary>
    public Vector3 diff = Vector3.positiveInfinity;
    Vector3 relativeVelocity;
    public float predictedInterceptTime;
    public Vector3 predictedMovePosition;
    Vector3 predictedDiff;
    public float ComputePredictiveDH(/*offset maybe?*/)
    {
        float dh;
        movePosition = player.position /*add offset*/;
        diff = movePosition - monster.position;
        Debug.Log(diff);
        relativeVelocity = monster.velocity - player.velocity;
        predictedInterceptTime = diff.magnitude / relativeVelocity.magnitude;
        if (predictedInterceptTime >= 0)
        {
            predictedMovePosition = movePosition + (player.velocity * predictedInterceptTime);
            predictedDiff = predictedMovePosition - monster.position;
            dh = Utils.Degrees360(Mathf.Atan2(predictedDiff.x, predictedDiff.z) * Mathf.Rad2Deg);
        }
        else
        {
            dh = ComputeDH();
        }
        return dh;
    }

    public float dhRadians;
    public float dhDegrees;
    public float ComputeDH()
    {
        diff = movePosition - monster.position;
        dhRadians = Mathf.Atan2(diff.x, diff.z);
        dhDegrees = Utils.Degrees360(Mathf.Rad2Deg * dhRadians);
        return dhDegrees;
    }
}
