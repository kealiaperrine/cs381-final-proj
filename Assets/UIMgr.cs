using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : MonoBehaviour
{

    public static UIMgr inst;
    private void Awake()
    {
        inst = this;
    }
    
    void Start()
    {
        
    }

    public Text killCountNumber;
    // Update is called once per frame
    void Update()
    {
        killCountNumber.text = Player.inst.killCount.ToString();
    }
}
