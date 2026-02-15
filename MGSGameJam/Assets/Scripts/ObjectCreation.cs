using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class ObjectCreation : MonoBehaviour
{
    public GameObject[] object1 = new GameObject[3];
    public GameObject[] object2 = new GameObject[3];
    public GameObject[] object3 = new GameObject[3];

    [SerializeField] UnityEngine.UI.Button bset1;
    [SerializeField] UnityEngine.UI.Button bset2;
    [SerializeField] UnityEngine.UI.Button bset3;


    [SerializeField] int objNum;

    [SerializeField] int SucsessfulGuesses;

    [SerializeField] int totalCleintsSeen;

    // Start is called before the first frame update
    void Start()
    {
        totalCleintsSeen = StaticData.totalCleints;
        bset1.onClick.AddListener(bbset1);
        bset2.onClick.AddListener(bbset2);
        bset3.onClick.AddListener(bbset3);


        objNum = StaticData.presentobject;
    }
    // Update is called once per frame
    void Update()
    {
        WhichObject(objNum);

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

                }
                break;

            case 1:
                for (int i = 0; i < object1.Length; i++)
                {
                    object2[i].SetActive(true);
                    object1[i].SetActive(false);
                    object3[i].SetActive(false);

                }


                break;

            case 2:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(true);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);

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
                    break;

                case 1:

                    break;

                case 2:

                    break;

            }
            
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
                    
                    break;

                case 1:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    break;

                case 2:

                    break;

            }

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

                    break;

                case 1:
                    
                    break;

                case 2:
                    SucsessfulGuesses = SucsessfulGuesses + 1;
                    StaticData.correctGuesses = SucsessfulGuesses;
                    Debug.Log(SucsessfulGuesses);
                    break;

                }
            SceneManager.LoadScene("Game");

        }
        else
            SceneManager.LoadScene("EndScreen");
    }

}
