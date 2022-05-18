using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointScript : MonoBehaviour
{
    public int numOfPoints = 0;
    int wasPoints = 0;
    public Material skybox;
    public Color color;
    public GameObject Win;
    public GameObject Lose;
    public GameObject reset;
    bool OverForty = false;
    
    void Start()
    {

        Time.timeScale = 1;
        color = new Color(1, 0.18f, 0);

    }

    // Update is called once per frame

    void Update()
    {
        skybox.SetColor("_Tint", color);
       
       
        //checks if points are more or less

        if(numOfPoints > 45)
        {
            OverForty = true;
        }
        else
        {
            OverForty = false;
        }
        if (numOfPoints != wasPoints )
        {//points added

            
            if (numOfPoints > wasPoints)
            {
               
                if (OverForty ==  true)
                {
                    wasPoints = numOfPoints;
                    color = new Color(color.r - 0.018f, 1, 0);
                }
                if (OverForty == false)
                {
                    wasPoints = numOfPoints;
                    color = new Color(1, color.g - 0.018f, 0);
                }

            } //points lowered
            if(numOfPoints < wasPoints)
            {
                if (OverForty == false)
                {
                    wasPoints = numOfPoints;
                    color = new Color(1, color.g - 0.018f, 0);
                }
                if (OverForty == true)
                {
                    wasPoints = numOfPoints;
                    color = new Color(color.r + 0.018f, 1 , 0);
                }
            }
        }

        if (numOfPoints > 99)
        {
            Win.SetActive(true);
            Time.timeScale = 0;
            reset.SetActive(true);
        }
        if (numOfPoints < -9)
        {
            Lose.SetActive(true);
            Time.timeScale = 0;
            reset.SetActive(true);
        }

        


    }
    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
