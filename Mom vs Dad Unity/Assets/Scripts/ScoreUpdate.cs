using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    TMPro.TextMeshProUGUI daScore;
    
    private void Start()
    {
        daScore = GetComponent<TMPro.TextMeshProUGUI>();
        
        
    }
    private void Update()
    {
        daScore.text = PointScript.numOfPoints.ToString();
    }
}
