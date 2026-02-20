using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;


public class ObjectCreation : MonoBehaviour
{
    public GameObject[] object1 = new GameObject[4];
    public GameObject[] object2 = new GameObject[4];
    public GameObject[] object3 = new GameObject[4];
    public GameObject[] object4 = new GameObject[4];
    public GameObject[] object5 = new GameObject[4];
    public GameObject[] object6 = new GameObject[4];
    public GameObject[] object7 = new GameObject[4];
    public GameObject[] object8 = new GameObject[4];
    public GameObject[] object9 = new GameObject[4];
    public GameObject[] object10 = new GameObject[4];
    public GameObject[] object11 = new GameObject[4];
    public GameObject[] object12 = new GameObject[4];
    public GameObject[] object13 = new GameObject[4];

    [SerializeField] UnityEngine.UI.Button bset1;
    [SerializeField] UnityEngine.UI.Button bset2;
    [SerializeField] UnityEngine.UI.Button bset3;
    [SerializeField] UnityEngine.UI.Button bset4;

    [SerializeField] TextMeshProUGUI p1;
    [SerializeField] TextMeshProUGUI p2;
    [SerializeField] TextMeshProUGUI p3;
    [SerializeField] TextMeshProUGUI p4;


    [SerializeField] int objNum;

    [SerializeField] int SucsessfulGuesses;

    [SerializeField] int totalCleintsSeen;

    [SerializeField] TextMeshProUGUI balanceText;

    // Start is called before the first frame update
    void Start()
    {
        totalCleintsSeen = StaticData.totalCleints;
        bset1.onClick.AddListener(bbset1);
        bset2.onClick.AddListener(bbset2);
        bset3.onClick.AddListener(bbset3);
        bset4.onClick.AddListener(bbset4);

        objNum = StaticData.presentobject;
        SucsessfulGuesses = StaticData.correctGuesses;
        balanceText.text = "Balance: "+(StaticData.balance).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        switch (objNum)
        {
            case 0:
                p1.text = "50g";
                break;

            case 1:
                p1.text = "666g";
                break;

            case 2:
                p1.text = "43g";
                break;

            case 3:
                p1.text = "30g";
                break;
            case 4:
                p1.text = "12g";
                break;
            case 5:
                p1.text = "70g";
                break;
            case 6:
                p1.text = "200g";
                break;
            case 7:
                p1.text = "430g";
                break;
            case 8:
                p1.text = "180g";
                break;
            case 9:
                p1.text = "120g";
                break;
            case 10:
                p1.text = "250g";
                break;
            case 11:
                p1.text = "12g";
                break;
            case 12:
                p1.text = "460g";
                break;


        }
        switch (objNum)
        {
            case 0:
                p2.text = "490g";
                break;

            case 1:
                p2.text = "36g";
                break;

            case 2:
                p2.text = "57g";
                break;

            case 3:
                p2.text = "3g";
                break;
            case 4:
                p2.text = "5g";
                break;
            case 5:
                p2.text = "50g";
                break;
            case 6:
                p2.text = "100g";
                break;
            case 7:
                p2.text = "100g";
                break;
            case 8:
                p2.text = "110g";
                break;
            case 9:
                p2.text = "170g";
                break;
            case 10:
                p2.text = "322g";
                break;
            case 11:
                p2.text = "134g";
                break;
            case 12:
                p2.text = "600g";
                break;

        }
        switch (objNum)
        {
            case 0:
                p3.text = "25g";
                break;

            case 1:
                p3.text = "490g";
                break;

            case 2:
                p3.text = "32g";
                break;

            case 3:
                p3.text = "5g";
                break;
            case 4:
                p3.text = "8g";
                break;
            case 5:
                p3.text = "50g";
                break;
            case 6:
                p3.text = "100g";
                break;
            case 7:
                p3.text = "70g";
                break;
            case 8:
                p3.text = "50g";
                break;
            case 9:
                p3.text = "80g";
                break;
            case 10:
                p3.text = "180g";
                break;
            case 11:
                p3.text = "122g";
                break;
            case 12:
                p3.text = "406g";
                break;

        }

        switch (objNum)
        {
            case 0:
                p4.text = "48g";
                break;

            case 1:
                p4.text = "57g";
                break;

            case 2:
                p4.text = "100g";
                break;
            case 3:
                p4.text = "48g";
                break;
            case 4:
                p4.text = "5g";
                break;
            case 5:
                p4.text = "20g";
                break;
            case 6:
                p4.text = "555g";
                break;
            case 7:
                p4.text = "180g";
                break;
            case 8:
                p4.text = "90g";
                break;
            case 9:
                p4.text = "60g";
                break;
            case 10:
                p4.text = "210g";
                break;
            case 11:
                p4.text = "90g";
                break;
            case 12:
                p4.text = "640g";
                break;

        }

        WhichObject(objNum);

        if (StaticData.balance <= 0)
            SceneManager.LoadScene("EndScreen");
    }
    void WhichObject(int obj)
    {
        switch (obj)
        {
            case 0:
                for (int i = 0; i < object1.Length; i++)
                {
                    object1[i].SetActive(true);
                    object2[i].SetActive(false);
                    object3[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);

                }
                break;

            case 1:
                for (int i = 0; i < object1.Length; i++)
                {
                    object2[i].SetActive(true);
                    object1[i].SetActive(false);
                    object3[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);

                }


                break;

            case 2:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(true);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);

                }
                break;

            case 3:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(true);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);


                }
                break;

            case 4:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(true);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);

                }
                break;
            case 5:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(true);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);
                }
                break;
            case 6:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(true);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);
                }
                break;
            case 7:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(true);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);
                }
                break;
            case 8:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(true);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);
                }
                break;
            case 9:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(true);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);
                }
                break;
            case 10:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(true);
                    object12[i].SetActive(false);
                    object13[i].SetActive(false);
                }
                break;
            case 11:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(true);
                    object13[i].SetActive(false);
                }
                break;
            case 12:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(false);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);
                    object4[i].SetActive(false);
                    object5[i].SetActive(false);
                    object6[i].SetActive(false);
                    object7[i].SetActive(false);
                    object8[i].SetActive(false);
                    object9[i].SetActive(false);
                    object10[i].SetActive(false);
                    object11[i].SetActive(false);
                    object12[i].SetActive(false);
                    object13[i].SetActive(true);
                }
                break;
        }
    }

    void bbset1()
    {
        if (totalCleintsSeen <= 3)
        {
            switch (objNum)
            {
                case 0:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);

                    StaticData.balance = StaticData.balance - 50;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "50g";
                    break;

                case 1:
                    StaticData.balance = StaticData.balance - 666;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "666g";
                    break;

                case 2:
                    StaticData.balance = StaticData.balance - 43;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "43g";
                    break;

                case 3:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 30;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "30g";
                    break;
                case 4:
                    StaticData.balance = StaticData.balance - 12;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "12g";
                    break;
                case 5:
                    StaticData.balance = StaticData.balance - 70;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "70g";
                    break;
                case 6:
                    StaticData.balance = StaticData.balance - 200;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "200g";
                    break;
                case 7:
                    StaticData.balance = StaticData.balance - 430;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "430g";
                    break;
                case 8:
                    StaticData.balance = StaticData.balance - 180;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "180g";
                    break;
                case 9:
                    StaticData.balance = StaticData.balance - 120;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "120g";
                    break;
                case 10:
                    StaticData.balance = StaticData.balance - 250;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "250g";
                    break;
                case 11:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 12;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "12g";
                    break;
                case 12:
                    StaticData.balance = StaticData.balance - 460;      /////------PRICE OF OBJECT -------//////////
                    p1.text = "460g";
                    break;


            }
            
            balanceText.text = "Balance: " + (StaticData.balance).ToString();
            SceneManager.LoadScene("Game");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset2()
    {
        if (totalCleintsSeen <= 3)
        {
            switch (objNum)
            {
                case 0:
                    StaticData.balance = StaticData.balance - 490;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "490g";
                    break;

                case 1:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 36;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "36g";
                    break;

                case 2:
                    StaticData.balance = StaticData.balance - 57;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "57g";
                    break;

                case 3:
                    StaticData.balance = StaticData.balance - 3;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "3g";
                    break;
                case 4:
                    StaticData.balance = StaticData.balance - 5;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "5g";
                    break;
                case 5:
                    StaticData.balance = StaticData.balance - 50;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "50g";
                    break;
                case 6:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "100g";
                    break;
                case 7:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "100g";
                    break;
                case 8:
                    StaticData.balance = StaticData.balance - 110;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "110g";
                    break;
                case 9:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 170;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "170g";
                    break;
                case 10:
                    StaticData.balance = StaticData.balance - 322;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "322g";
                    break;
                case 11:
                    StaticData.balance = StaticData.balance - 134;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "134g";
                    break;
                case 12:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 600;      /////------PRICE OF OBJECT -------//////////
                    p2.text = "600g";
                    break;

            }

            balanceText.text = "Balance: " + (StaticData.balance).ToString();
            SceneManager.LoadScene("Game");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset3()
    {
        if (totalCleintsSeen <= 3)
        {
            switch(objNum)
            {
                case 0:
                    StaticData.balance = StaticData.balance - 25;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "25g";
                    break;

                case 1:
                    StaticData.balance = StaticData.balance - 490;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "490g";
                    break;

                case 2:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);

                    StaticData.balance = StaticData.balance - 32;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "32g";
                    break;

                case 3:
                    StaticData.balance = StaticData.balance - 5;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "5g";
                    break;
                case 4:
                    StaticData.balance = StaticData.balance - 8;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "8g";
                    break;
                case 5:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 50;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "50g";
                    break;
                case 6:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "100g";
                    break;
                case 7:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 70;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "70g";
                    break;
                case 8:
                    StaticData.balance = StaticData.balance - 50;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "50g";
                    break;
                case 9:
                    StaticData.balance = StaticData.balance - 80;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "80g";
                    break;
                case 10:
                    StaticData.balance = StaticData.balance - 180;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "180g";
                    break;
                case 11:
                    StaticData.balance = StaticData.balance - 122;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "122g";
                    break;
                case 12:
                    StaticData.balance = StaticData.balance - 406;      /////------PRICE OF OBJECT -------//////////
                    p3.text = "406g";
                    break;

            }

            balanceText.text = "Balance: " + (StaticData.balance).ToString();
            SceneManager.LoadScene("Game");

        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset4()
    {
        if (totalCleintsSeen <= 3)
        {
            switch (objNum)
            {
                case 0:
                    StaticData.balance = StaticData.balance - 48;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "48g";
                    break;

                case 1:
                    StaticData.balance = StaticData.balance - 57;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "57g";
                    break;

                case 2:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "100g";
                    break;
                case 3:
                    StaticData.balance = StaticData.balance - 48;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "48g";
                    break;
                case 4:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 5;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "5g";
                    break;
                case 5:
                    StaticData.balance = StaticData.balance - 20;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "20g";
                    break;
                case 6:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 555;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "555g";
                    break;
                case 7:
                    StaticData.balance = StaticData.balance - 180;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "180g";
                    break;
                case 8:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 90;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "90g";
                    break;
                case 9:
                    StaticData.balance = StaticData.balance - 60;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "60g";
                    break;
                case 10:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 210;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "210g";
                    break;
                case 11:
                    StaticData.balance = StaticData.balance - 90;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "90g";
                    break;
                case 12:
                    StaticData.balance = StaticData.balance - 640;      /////------PRICE OF OBJECT -------//////////
                    p4.text = "640g";
                    break;

            }

            balanceText.text = "Balance: " + (StaticData.balance).ToString();
            SceneManager.LoadScene("Game");

        }
        else
            SceneManager.LoadScene("EndScreen");
    }

}
