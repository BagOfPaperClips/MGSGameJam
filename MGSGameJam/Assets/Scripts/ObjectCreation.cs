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

    [SerializeField] UnityEngine.UI.Button bset11;
    [SerializeField] UnityEngine.UI.Button bset12;
    [SerializeField] UnityEngine.UI.Button bset13;

    [SerializeField] UnityEngine.UI.Button bset21;
    [SerializeField] UnityEngine.UI.Button bset22;
    [SerializeField] UnityEngine.UI.Button bset23;

    [SerializeField] UnityEngine.UI.Button bset31;
    [SerializeField] UnityEngine.UI.Button bset32;
    [SerializeField] UnityEngine.UI.Button bset33;

    [SerializeField] int objNum;

    [SerializeField] int SucsessfulGuesses;

    [SerializeField] int totalCleintsSeen;

    // Start is called before the first frame update
    void Start()
    {
        totalCleintsSeen = StaticData.totalCleints;
        bset11.onClick.AddListener(bbset11);
        bset12.onClick.AddListener(bbset12);
        bset13.onClick.AddListener(bbset13);

        bset21.onClick.AddListener(bbset21);
        bset22.onClick.AddListener(bbset22);
        bset23.onClick.AddListener(bbset23);

        bset31.onClick.AddListener(bbset31);
        bset32.onClick.AddListener(bbset32);
        bset33.onClick.AddListener(bbset33);

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
                bset11.gameObject.SetActive(true);
                bset12.gameObject.SetActive(true);
                bset13.gameObject.SetActive(true);

                bset21.gameObject.SetActive(false);
                bset22.gameObject.SetActive(false);
                bset23.gameObject.SetActive(false);

                bset31.gameObject.SetActive(false);
                bset32.gameObject.SetActive(false);
                bset33.gameObject.SetActive(false);
                break;

            case 1:
                for (int i = 0; i < object1.Length; i++)
                {
                    object2[i].SetActive(true);
                    object1[i].SetActive(false);
                    object3[i].SetActive(false);

                }

                bset11.gameObject.SetActive(false);
                bset12.gameObject.SetActive(false);
                bset13.gameObject.SetActive(false);

                bset21.gameObject.SetActive(true);
                bset22.gameObject.SetActive(true);
                bset23.gameObject.SetActive(true);

                bset31.gameObject.SetActive(false);
                bset32.gameObject.SetActive(false);
                bset33.gameObject.SetActive(false);

                break;

            case 2:
                for (int i = 0; i < object1.Length; i++)
                {
                    object3[i].SetActive(true);
                    object2[i].SetActive(false);
                    object1[i].SetActive(false);

                }

                bset11.gameObject.SetActive(false);
                bset12.gameObject.SetActive(false);
                bset13.gameObject.SetActive(false);

                bset21.gameObject.SetActive(false);
                bset22.gameObject.SetActive(false);
                bset23.gameObject.SetActive(false);

                bset31.gameObject.SetActive(true);
                bset32.gameObject.SetActive(true);
                bset33.gameObject.SetActive(true);

                break;

        }
    }

    void bbset11()
    {
        if (totalCleintsSeen <= 3)
        {
            SucsessfulGuesses = SucsessfulGuesses + 1;
            StaticData.correctGuesses = SucsessfulGuesses;

            Debug.Log(SucsessfulGuesses);
            SceneManager.LoadScene("Game");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset12()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");

            SceneManager.LoadScene("Game");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset13()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");

            SceneManager.LoadScene("Game");

        }
        else
            SceneManager.LoadScene("EndScreen");
    }

    /// <summary>
    /// ---------------------
    /// </summary>

    void bbset21()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");
            SucsessfulGuesses = SucsessfulGuesses + 1;
            StaticData.correctGuesses = SucsessfulGuesses;
            Debug.Log(SucsessfulGuesses);

            SceneManager.LoadScene("Game");
            //SceneManager.LoadScene("ActionTime");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset22()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");

            SceneManager.LoadScene("Game");
            //SceneManager.LoadScene("ActionTime");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset23()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");

            SceneManager.LoadScene("Game");
            //SceneManager.LoadScene("ActionTime");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }

    /// <summary>
    /// ----------------------
    /// </summary>
    void bbset31()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");

            SceneManager.LoadScene("Game");
            //SceneManager.LoadScene("ActionTime");
        }
        else
            SceneManager.LoadScene("EndScreen");

    }
    void bbset32()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");
            SucsessfulGuesses = SucsessfulGuesses + 1;
            StaticData.correctGuesses = SucsessfulGuesses;

            SceneManager.LoadScene("Game");
            Debug.Log(SucsessfulGuesses);
            //SceneManager.LoadScene("ActionTime");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }
    void bbset33()
    {
        if (totalCleintsSeen <= 3)
        {
            Debug.Log("END");
            SceneManager.LoadScene("Game");
            //SceneManager.LoadScene("ActionTime");
        }
        else
            SceneManager.LoadScene("EndScreen");
    }

}
