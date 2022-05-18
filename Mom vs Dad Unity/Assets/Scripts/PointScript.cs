using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointScript : MonoBehaviour
{
    public int numOfPoints = 0;
    public Material skybox;
    public Color color;
    public GameObject Win;
    public GameObject Lose;
    public GameObject reset;
    void Start()
    {

        Time.timeScale = 1;

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
        else if(numOfPoints < 45 && numOfPoints > 0 )
        {
            color = new Color(1, 1 - (0.009f * numOfPoints), 0);
        }
        else if (numOfPoints < 45 && numOfPoints < 0)
        {
            color = new Color(1, 1 - (0.009f * numOfPoints * -11), 0);
        }

        if(numOfPoints > 99)
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
