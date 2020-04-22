using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMgr : MonoBehaviour
{
 
    public static LineMgr inst;
    private void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        lines.Clear();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<LineRenderer> lines = new List<LineRenderer>();
    public LineRenderer MovePrefab;
    public LineRenderer CreateLine(Vector3 p1, Vector3 p2)
    {
        LineRenderer lr = Instantiate<LineRenderer>(MovePrefab, transform);
        lr.SetPosition(0, p1);
        lr.SetPosition(1, p2);
        lines.Add(lr);
        return lr;
    }

    public LineRenderer temp;
    public void DestroyLR(LineRenderer lr)
    {
        temp = null;
        if (lines.Contains(lr))
        {
            temp = lr;
            lines.Remove(lr);
        }
        Destroy(lr);
    }
}
