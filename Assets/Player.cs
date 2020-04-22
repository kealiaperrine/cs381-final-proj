using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player inst;

    private void Awake()
    {
        inst = this;
    }

    public GameObject playerEntity;
    public float playerMoveSpeed = 5;
    public Vector3 position;
    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        //playerEntity = transform.Find("Player").gameObject;
        position = transform.localPosition;
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            playerEntity.transform.Translate(Vector3.forward * Time.deltaTime * playerMoveSpeed);
            velocity = (Vector3.forward * Time.deltaTime * playerMoveSpeed);
            position += (Vector3.forward * Time.deltaTime * playerMoveSpeed);
        }            
        if (Input.GetKey(KeyCode.S))
        {
            playerEntity.transform.Translate(Vector3.back * Time.deltaTime * playerMoveSpeed);
            velocity = Vector3.back * Time.deltaTime * playerMoveSpeed;
            position += Vector3.back * Time.deltaTime * playerMoveSpeed;
        }            
        if (Input.GetKey(KeyCode.A))
        {
            playerEntity.transform.Translate(Vector3.left * Time.deltaTime * playerMoveSpeed);
            velocity = Vector3.left * Time.deltaTime * playerMoveSpeed;
            position += Vector3.left * Time.deltaTime * playerMoveSpeed;
        }            
        if (Input.GetKey(KeyCode.D))
        {
            playerEntity.transform.Translate(Vector3.right * Time.deltaTime * playerMoveSpeed);
            velocity = Vector3.right * Time.deltaTime * playerMoveSpeed;
            position += Vector3.right * Time.deltaTime * playerMoveSpeed;
        }
            
        
        //change direction player is facing
    }
}
