using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float X;
    Rigidbody rb;
    Vector3 move;
    public float speed;

    public Transform GroundCheckTransform;
    public float GroundCheckSize;
    RaycastHit hit;
    public LayerMask GroundMask;

    bool isGrounded = true;
    public float JumpForce;
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
        rb.AddForce(move*speed*Time.deltaTime);

        //GROUND CHECK 
        if(Physics.Raycast(transform.position, new Vector3(0, -1, 0) * GroundCheckSize, out hit, GroundMask))
        {
            isGrounded = false;
            Debug.Log("Did Hit");
            Debug.DrawRay(transform.position, new Vector3(0, -1, 0) * GroundCheckSize, Color.green);
        }
        else
        {
            isGrounded = false;
            Debug.Log("Didn't Hit");
        }

        //JUMP
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 JumpDirection = new Vector3(0, 1, 0);
            rb.AddForce(JumpDirection * JumpForce);
        }
    }
}
