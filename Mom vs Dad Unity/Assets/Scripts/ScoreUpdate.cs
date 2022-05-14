using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    TMPro.TextMeshProUGUI daScore;
    PointScript pSUI;
    GameObject pGeatherer;
    private void Start()
    {
        daScore = GetComponent<TMPro.TextMeshProUGUI>();
        pGeatherer = GameObject.Find("PointGeatherer");
        pSUI = pGeatherer.GetComponent<PointScript>();
        
    }
    private void Update()
    {
        daScore.text = pSUI.numOfPoints.ToString();
    }
}
