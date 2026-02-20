using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterSelection : MonoBehaviour
{
    public string[] ClientsNames = { "Client1", "Client2", "Client3", "Client4", "Client5" };
    [SerializeField] int numberOfClients;
    [SerializeField] int clientNum;
    [SerializeField] int numClient = 0;

    public string[][] ObjectDescriptions = new string[13][];
    
    [SerializeField] int NumberOfObjects;
    public int objNum;

    [SerializeField] TextMeshProUGUI disc;
    [SerializeField] TextMeshProUGUI balanceAmount;

    public int choicePart = 0;

    [SerializeField] GameObject Client1;
    [SerializeField] GameObject Client2;
    [SerializeField] GameObject Client3;
    [SerializeField] GameObject Client4;
    [SerializeField] GameObject Client5;

    [SerializeField] UnityEngine.UI.Button b;
    [SerializeField] UnityEngine.UI.Button b1;
    [SerializeField] UnityEngine.UI.Button b2;
    [SerializeField] UnityEngine.UI.Button b3;

    public GameObject playCupChallengeButton;
    public GameObject cupGameScreen;

    public GameObject dialogueBox;

    private bool flag1 = false;
    private bool flag2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        b.onClick.AddListener(SeeClient);
        b1.onClick.AddListener(Help);
        b2.onClick.AddListener(Action);
        b3.onClick.AddListener(GO);
        playCupChallengeButton.SetActive(false);

        dialogueBox.SetActive(false);

        //OBJECT1
        ObjectDescriptions[0] = new string[] { "Discription1P1", "Discription1P2" , "Discription1P3", "Theres Nothing else to say" };

        //OBJECT2
        ObjectDescriptions[1] = new string[] { "Discription2P1", "Discription2P2", "Discription2P3", "Theres Nothing else to say" };

        //OBJECT3
        ObjectDescriptions[2] = new string[] { "Discription3P1", "Discription3P2", "Discription3P3", "Theres Nothing else to say" };

        //OBJECT4
        ObjectDescriptions[3] = new string[] { "Discription4P1", "Discription4P2", "Discription4P3", "Theres Nothing else to say" };

        //OBJECT5
        ObjectDescriptions[4] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT6
        ObjectDescriptions[5] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT7
        ObjectDescriptions[6] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT8
        ObjectDescriptions[7] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT9
        ObjectDescriptions[8] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT10
        ObjectDescriptions[9] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT11
        ObjectDescriptions[10] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT12
        ObjectDescriptions[11] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };

        //OBJECT13
        ObjectDescriptions[12] = new string[] { "Discription5P1", "Discription5P2", "Discription5P3", "Theres Nothing else to say" };
        balanceAmount.text = "Balance: " + (StaticData.balance).ToString();
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

        if (StaticData.balance <= 0)
            SceneManager.LoadScene("EndScreen");
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
        clientNum = Random.Range(0, 4);
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
            Client4.SetActive(false);
            Client5.SetActive(false);
        }
        else if (clientNum == 1){
            Client2.SetActive(true);

            Client1.SetActive(false);
            Client3.SetActive(false);
            Client4.SetActive(false);
            Client5.SetActive(false);
        }
        else if (clientNum == 2)
        {
            Client3.SetActive(true);

            Client2.SetActive(false);
            Client1.SetActive(false);
            Client4.SetActive(false);
            Client5.SetActive(false);
        }
        else if (clientNum == 3)
        {
            Client4.SetActive(true);

            Client2.SetActive(false);
            Client1.SetActive(false);
            Client3.SetActive(false);
            Client5.SetActive(false);
        }
        else
        {
            Client5.SetActive(true);

            Client2.SetActive(false);
            Client1.SetActive(false);
            Client4.SetActive(false);
            Client3.SetActive(false);
        }
        

        return clientNum;
    }

    public int NewObject()
    {
        //Randomly picks an Object from the list and plays the first discription
        //NumberOfObjects = ObjectDescriptions.Length;
        NumberOfObjects = 12;                                ///CHANGE THIS WHEN MORE ITEMS ARE ADDED
        objNum = Random.Range(0, NumberOfObjects);
        StaticData.presentobject = objNum;
        Debug.Log("Object: " + objNum);
        PrintDialog(ObjectDescriptions[objNum][0]);
        choicePart = 0;
        //Gives you the option to get more help

        return objNum;
    }

    public void choiceTree()
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

    public void PrintDialog(string dialog)
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

        dialogueBox.SetActive(true);
        //flag1 = true;
    }

    public void Help()
    {
        //flag1 = false;
        Debug.Log("Asked for hint");
        choicePart = choicePart + 1;
        PrintDialog(ObjectDescriptions[objNum][choicePart]);
        StaticData.balance = StaticData.balance - 200;      /////------PRICE OF HINT -------//////////

        balanceAmount.text = "Balance: " + (StaticData.balance).ToString();
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
        playCupChallengeButton.SetActive(true);
    }

    public void StartCupGame()
    {
        cupGameScreen.SetActive(true);
    }
}
