using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float X;
    public Rigidbody rb;
    Vector3 move;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVE
        X = Input.GetAxis("Horizontal");
        move = new Vector3(X, 0f, 0f);
        rb.AddForce(move * speed * Time.deltaTime);

    }
}
