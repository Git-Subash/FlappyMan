using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManger : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    int score = 0;
    public static ScoreManger instance;

 void Awake() 
 {
        instance = this;
}

 void Start() 
 {
    Scoretext.text = "MONEY: " + score .ToString();
        
}

public void AddPoints()
{
    score += 1;
    Scoretext.text = "MONEY: " + score .ToString();
}



}
