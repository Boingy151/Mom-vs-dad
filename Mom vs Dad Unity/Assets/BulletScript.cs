using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    GameObject Player;
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody>();
        transform.LookAt(Player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = Vector3.forward*-1*speed*Time.deltaTime;
    }
}
