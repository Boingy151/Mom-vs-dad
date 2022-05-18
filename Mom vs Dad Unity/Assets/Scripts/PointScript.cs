using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    public int numOfPoints = 0;
    public Material skybox;
    public Color color;
    void Start()
    {
        


    }

    // Update is called once per frame

    void Update()
    {
        skybox.SetColor("_Tint", color);
        if (numOfPoints > 0)
        {
            color = new Color(1-(0.009f*numOfPoints), 1, 0);
            Debug.Log(color.r);
        }
        else if(numOfPoints < 45 && numOfPoints >0 )
        {
            color = new Color(1, 1 - (0.009f * numOfPoints), 0);
        }
        else if (numOfPoints < 45 && numOfPoints < 0)
        {
            color = new Color(1, 1 - (0.009f * numOfPoints * -1), 0);
        }


    }
    
}
