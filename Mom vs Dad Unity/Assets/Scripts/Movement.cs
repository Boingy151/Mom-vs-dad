using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float X;
    Rigidbody rigidbody;
    Vector3 move;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        X = Input.GetAxis("Horizontal");
        move = new Vector3(X, 0, 0);
        rigidbody.AddForce(move * speed * Time.deltaTime);

    }
}
