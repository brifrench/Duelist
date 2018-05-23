using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerArea;
    [SerializeField]
    GameObject[] spells;


    public int speed = 1;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    


    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private double squareLength = 4.5;


    public GameObject projectile;
    public Transform Spawnpoint;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {


        //if (Input.GetMouseButton(1) == true)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        if (Input.GetMouseButtonDown(1) == true)
        {


  
            GameObject bullet = Instantiate(spells[2], Spawnpoint.position, this.transform.rotation );
            //Rigidbody holder = bullet.AddComponent<Rigidbody>();
            
            //holder.mass = .1f;
            //holder.collisionDetectionMode = CollisionDetectionMode.Continuous;
            //holder.AddForce(transform.forward * 100);
            //holder.useGravity = false;


          

        }


        Vector3 pos = transform.position;



        if (Input.GetKey("w"))
        {
            if (pos.z + speed * Time.deltaTime <= squareLength)
            {
                pos.z += speed * Time.deltaTime;

            }

        }
        if (Input.GetKey("s"))
        {
            if (pos.z - speed * Time.deltaTime >= -squareLength)
            {
                pos.z -= speed * Time.deltaTime;

            }

        }
        if (Input.GetKey("d"))
        {
            if (pos.x + speed * Time.deltaTime <= squareLength)
            {
                pos.x += speed * Time.deltaTime;

            }

        }
        if (Input.GetKey("a"))
        {
            if (pos.x - speed * Time.deltaTime >= -squareLength)
            {
                pos.x -= speed * Time.deltaTime;
            }

        }


        transform.position = pos;
    }
}
