using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMgr : MonoBehaviour
{

    public LineRenderer line;

    public static CombatMgr inst;
    private void Awake() {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        layerMask = LayerMask.GetMask("Ground");
    }

    public RaycastHit hit;
    public int layerMask;
    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, float.MaxValue, layerMask))
            {
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.yellow, 2);
              //  line = LineMgr.inst.CreateLine(Player.inst.position, hit.point);
               // line.gameObject.SetActive(false);
               // line.SetPosition(1, hit.point);
               // LineMgr.inst.DestroyLR(line);
            }
        }*/
        
    }
}
