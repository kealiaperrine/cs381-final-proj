using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMgr : MonoBehaviour
{
    public static MonsterMgr inst;
    public Player player;
    public List<Monster> monsters;
    private void Awake()
    {
        inst = this;

    }

    void Start()
    {
        inst = this;
        //monsters = new List<Monster>();
    }

    bool close = false;
    // Update is called once per frame
    void Update()
    {
        foreach(Monster mon in monsters)
        {
            close = PlayerCloseEnough(mon);
            if (close)
            {
                //Debug.Log("ADDING INTERCEPT ");
                Intercept intercept = new Intercept(mon, Player.inst);
                UnitAI uai = mon.GetComponent<UnitAI>();
                uai.AddCommand(intercept);
                //Debug.Log(mon.velocity);

            }
            //Debug.Log("Player close false ");
        }
    }

    public float InterceptRadiusSqr = 50.0f;
    bool PlayerCloseEnough(Monster mon)
    {
        float distanceSq = (mon.position - player.position).sqrMagnitude;
        //Debug.Log(distanceSq);
        //Debug.Log(mon.position);
        //Debug.Log(Player.inst.position);
        // Debug.Log(distanceSq <= InterceptRadiusSqr);
        if (distanceSq <= InterceptRadiusSqr)
            return true;
        else
            return false;
    }
}
