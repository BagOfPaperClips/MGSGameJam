using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
    public string[] ClientsNames = { "Client1", "Client2", "Client3" };
    [SerializeField] int numberOfClients;
    [SerializeField] int clientNum;

    public string[][] ObjectDescriptions = new string[3][];
    
    [SerializeField] int NumberOfObjects;
    [SerializeField] int objNum;

    [SerializeField] TextMeshProUGUI disc;

    [SerializeField] int choicePart = 0;

    [SerializeField] GameObject Client1;
    [SerializeField] GameObject Client2;
    [SerializeField] GameObject Client3;

    // Start is called before the first frame update
    void Start()
    {
        //OBJECT1
        ObjectDescriptions[0] = new string[] { "Discription1P1", "Discription1P2" , "Discription1P3" };

        //OBJECT2
        ObjectDescriptions[1] = new string[] { "Discription2P1", "Discription2P2", "Discription2P3" };

        //OBJECT3
        ObjectDescriptions[2] = new string[] { "Discription3P1", "Discription3P2", "Discription3P3" };

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            clientNum = NewClient();
            Debug.Log("NEWCLIENT");
        }

        choiceTree();

        if (Input.GetKeyDown(KeyCode.C))
        {
            NewObject();
        }
    }

    int NewClient()
    {
        numberOfClients = ClientsNames.Length;
        clientNum = Random.Range(0, numberOfClients);
        Debug.Log("Client: " + clientNum);
        PrintDialog(ClientsNames[clientNum]);

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
        if (Input.GetKeyDown(KeyCode.C))
        {
            NewObject();
        }

        return clientNum;
    }

    int NewObject()
    {
        //Randomly picks an Object from the list and plays the first discription
        //NumberOfObjects = ObjectDescriptions.Length;
        NumberOfObjects = 3;
        objNum = Random.Range(0, NumberOfObjects);
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
            //END OF HINTS
            PrintDialog("CUTOFF");

        }

        //ASKING FOR A HINT
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Asked for hint");
            choicePart = choicePart + 1;
            PrintDialog(ObjectDescriptions[objNum][choicePart]);
            //REMOVE MONEY FROM THEIR BANK

        }

        //NO MORE NEED TO HINTS
        if (Input.GetKeyDown(KeyCode.P))
            PrintDialog("STARTAUCTION");

    }

    void PrintDialog(string dialog)
    {
        //Prints Dialog
        disc.text = dialog;
    }
}
