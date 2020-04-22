using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMgr : MonoBehaviour
{
    public static AIMgr inst;
    private void Awake()
    {
        inst = this;
    }

    public Player player;
    void Start()
    {
        //layermask was set in combatmgr - also ai doesnt need raycast
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void HandleIntercept(Monster mon)
   //{
      // Intercept intercept = new Intercept(mon, player);
      //  UnitAI uai = mon.GetComponent<UnitAI>();
       // uai.AddCommand(intercept);
   // }

    //should probably be in combat?
   /* public Monster FindClosestMonsterInRadius(Vector3 point, float rsq)
    {
        Monster minMonst = null;
        float min = float.MaxValue;
       foreach (Monster mon in MonsterMgr.inst.monsters)
        {
            float distanceSq = (mon.transform.position - point).sqrMagnitude;
            if (distanceSq < rsq)
            {
                if (distanceSq < min)
                {
                    minMonst = mon;
                    min = distanceSq;
                }
            }
        }
        return minMonst;
    }*/ 

   // bool PlayerCloseEnough()
  //  {

   // }

}
