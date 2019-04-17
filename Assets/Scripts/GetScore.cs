using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public Text sc;
    

    void Start()
    {
        sc.text = "0"; 
    }

    void Update()
    {
        sc.text = Scores.scr.ToString();
    }
}
