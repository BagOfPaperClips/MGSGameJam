using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StaticData.correctGuesses = 0;
        StaticData.totalCleints = 0;
        StaticData.balance = 1000;
        StaticData.cupGamePlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
