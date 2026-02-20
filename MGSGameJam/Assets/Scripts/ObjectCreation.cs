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
        balanceText.text = "Balance: "+(StaticData.balance).ToString();
    }
    // Update is called once per frame
    void Update()
    {
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
                    object8[i].SetActive(true);
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
                    object8[i].SetActive(true);
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

                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 1:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 2:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 3:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 4:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 5:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 6:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 7:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 8:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 9:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 10:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 11:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 12:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
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
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 1:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 2:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 3:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 4:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    break;
                case 5:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 6:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 7:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 8:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 9:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 10:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 11:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 12:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
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
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 1:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 2:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);

                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 3:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 4:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 5:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 6:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 7:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 8:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 9:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 10:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 11:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 12:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
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
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 1:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

                case 2:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 3:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 4:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 5:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 6:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 7:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 8:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 9:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 10:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 11:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;
                case 12:
                    StaticData.balance = StaticData.balance - 100;      /////------PRICE OF OBJECT -------//////////
                    break;

            }

            balanceText.text = "Balance: " + (StaticData.balance).ToString();
            SceneManager.LoadScene("Game");

        }
        else
            SceneManager.LoadScene("EndScreen");
    }

}
