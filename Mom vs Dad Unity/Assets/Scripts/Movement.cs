using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float X;
    public Rigidbody rb;
    Vector3 move;
    public float speed;
    Component refPScript;

    bool goingRight;
    bool goingLeft;
    bool motionStopped;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes movement instantanious instead of waiting for
        //the axis to get from 0 to 1 with its slow increments
        if (Input.GetKey(KeyCode.D))
        {
            X = 1;
            goingRight = true;
            motionStopped = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            X = -1;
            goingLeft = true;
            motionStopped = false;
        }
        else if (goingLeft && !motionStopped || goingRight && !motionStopped)
        {
            X = 0;
            goingRight = false;
            goingLeft = false;
            motionStopped = true;
        }
        move = new Vector3(X, 0f, 0f);
        rb.AddForce(move * speed * Time.deltaTime);
    }
    //this gets called every time the player hits grass so the score goes up by 1
    public void TouchedGrass()
    {
        GameObject playerC = GameObject.Find("PointGeatherer");
        PointScript refPScript = playerC.GetComponent<PointScript>();
        refPScript.numOfPoints++;
    }
}
