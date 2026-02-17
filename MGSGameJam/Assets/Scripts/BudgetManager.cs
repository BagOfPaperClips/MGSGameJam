using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BudgetManager : MonoBehaviour
{
    public TMP_Text budgetText;
    public int currentBudget;
    /*
    void Start()
    {
        if (StaticData.b1 == false)
        {
            RunStart();
        }
        
        StaticData.b1 = true;
        currentBudget = StaticData.budget;
    }

    void RunStart()
    {
        PlayerPrefs.SetInt("CurrentBudget", 1000);
        if (PlayerPrefs.HasKey("CurrentBudget"))
        {
            currentBudget = PlayerPrefs.GetInt("CurrentBudget");
        }
        else
        {
            currentBudget = 1000;
            PlayerPrefs.SetInt("CurrentBudget", 1000);
        }

        budgetText.text = "Budget: " + currentBudget;
    }

    // Start is called before the first frame update
    //void Awake()
    //{
    //    PlayerPrefs.SetInt("CurrentBudget", 1000);
    //    if (PlayerPrefs.HasKey("CurrentBudget"))
    //    {
    //        currentBudget = PlayerPrefs.GetInt("CurrentBudget");
    //    }
    //    else
    //    {
    //        currentBudget = 1000;
    //        PlayerPrefs.SetInt("CurrentBudget", 1000);
    //    }

    //    budgetText.text = "Budget: " + currentBudget;
    //}*/
    /*
    public void AddMoney(int moneyToAdd)
    {
        StaticData.budget = currentBudget;
        currentBudget = StaticData.budget;
        currentBudget += moneyToAdd;
        PlayerPrefs.SetInt("CurrentBudget", currentBudget);
        budgetText.text = "Budget: " + currentBudget;
        StaticData.budget = currentBudget;
        currentBudget = StaticData.budget;
    }*/
}
