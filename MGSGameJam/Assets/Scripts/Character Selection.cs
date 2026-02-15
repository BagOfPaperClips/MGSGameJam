using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterSelection : MonoBehaviour
{
    public string[] ClientsNames = { "Client1", "Client2", "Client3" };
    [SerializeField] int numberOfClients;
    [SerializeField] int clientNum;
    [SerializeField] int numClient = 0;

    public string[][] ObjectDescriptions = new string[3][];
    
    [SerializeField] int NumberOfObjects;
    [SerializeField] int objNum;

    [SerializeField] TextMeshProUGUI disc;

    [SerializeField] int choicePart = 0;

    [SerializeField] GameObject Client1;
    [SerializeField] GameObject Client2;
    [SerializeField] GameObject Client3;

    [SerializeField] UnityEngine.UI.Button b;
    [SerializeField] UnityEngine.UI.Button b1;
    [SerializeField] UnityEngine.UI.Button b2;
    [SerializeField] UnityEngine.UI.Button b3;

    private bool flag1 = false;
    private bool flag2 = false;
    // Start is called before the first frame update
    void Start()
    {
        b.onClick.AddListener(SeeClient);
        b1.onClick.AddListener(Help);
        b2.onClick.AddListener(Action);
        b3.onClick.AddListener(GO);

        //OBJECT1
        ObjectDescriptions[0] = new string[] { "Discription1P1", "Discription1P2" , "Discription1P3", "Theres Nothing else to say" };

        //OBJECT2
        ObjectDescriptions[1] = new string[] { "Discription2P1", "Discription2P2", "Discription2P3", "Theres Nothing else to say" };

        //OBJECT3
        ObjectDescriptions[2] = new string[] { "Discription3P1", "Discription3P2", "Discription3P3", "Theres Nothing else to say" };

        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.K))
        {
            clientNum = NewClient();
            Debug.Log("NEWCLIENT");
        }
        */
        choiceTree();

        /*
        if (Input.GetKeyDown(KeyCode.C))
        {
            NewObject();
        }*/
        /*
        if (flag1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NewObject();
                b1.gameObject.SetActive(true);
                b2.gameObject.SetActive(true);
            }
        }
        */
        if (flag2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("ActionTime");
                
            }
        }
    }

    int NewClient()
    {
        numberOfClients = ClientsNames.Length;
        clientNum = Random.Range(0, numberOfClients);
        Debug.Log("Client: " + clientNum);
        PrintDialog(ClientsNames[clientNum]);

        numClient = StaticData.totalCleints;

        numClient = numClient + 1;
        StaticData.totalCleints = numClient;

        //ENABLE AND DISSABLE CHARACTER SPRITES
        if (clientNum == 0)
        {
            Client1.SetActive(true);

            Client2.SetActive(false);
            Client3.SetActive(false);
        }
        else if (clientNum == 1){
            Client2.SetActive(true);

            Client1.SetActive(false);
            Client3.SetActive(false);
        }
        else
        {
            Client3.SetActive(true);

            Client2.SetActive(false);
            Client1.SetActive(false);
        }
        

        return clientNum;
    }

    int NewObject()
    {
        //Randomly picks an Object from the list and plays the first discription
        //NumberOfObjects = ObjectDescriptions.Length;
        NumberOfObjects = 3;
        objNum = Random.Range(0, NumberOfObjects);
        StaticData.presentobject = objNum;
        Debug.Log("Object: " + objNum);
        PrintDialog(ObjectDescriptions[objNum][0]);
        choicePart = 0;
        //Gives you the option to get more help

        return objNum;
    }

    void choiceTree()
    {
        if (choicePart == 3)
        {
            b1.gameObject.SetActive(false);
            flag2 = true;
        }

        /*
        //ASKING FOR A HINT
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Asked for hint");
            choicePart = choicePart + 1;
            PrintDialog(ObjectDescriptions[objNum][choicePart]);
            //REMOVE MONEY FROM THEIR BANK

        }
        */
        /*
        //NO MORE NEED TO HINTS
        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintDialog("STARTAUCTION");
            if (Input.GetKeyDown(KeyCode.Q))
                SceneManager.LoadScene("ActionTime");
        }
        */
    }

    void PrintDialog(string dialog)
    {
        //Prints Dialog
        disc.text = dialog;
    }

    // ----  BUTTONS ----- //

    void SeeClient()
    {
        clientNum = NewClient();
        Debug.Log("NEWCLIENT");
        b.gameObject.SetActive(false);


        b3.gameObject.SetActive(true);
        //flag1 = true;

    }

    void Help()
    {
        //flag1 = false;
        Debug.Log("Asked for hint");
        choicePart = choicePart + 1;
        PrintDialog(ObjectDescriptions[objNum][choicePart]);
    }
    void Action()
    {
        //flag1 = false;
        SceneManager.LoadScene("ActionTime");
    }

    void GO()
    {
        NewObject();
        b1.gameObject.SetActive(true);
        b2.gameObject.SetActive(true);
        b3.gameObject.SetActive(false);
    }
}
