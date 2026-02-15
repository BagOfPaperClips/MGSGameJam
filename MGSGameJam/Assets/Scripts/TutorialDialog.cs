using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net;
using UnityEngine.SceneManagement;

public class TutorialDialog : MonoBehaviour
{
    [SerializeField] int dialogCounter = 0;
    public string[] dialog = { "D1", "D2", "D3","D4" };
    [SerializeField] TextMeshProUGUI textObj;

    [SerializeField] UnityEngine.UI.Button next;
    // Start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(nextbit);
    }

    // Update is called once per frame
    void Update()
    {
        switch (dialogCounter)
        {
            case 0:
                textObj.text = dialog[0];

                break;
            case 1:
                textObj.text = dialog[1];

                break;
            case 2:
                textObj.text = dialog[2];

                break;
            case 3:
                textObj.text = dialog[3];

                break;
            case 4:
                SceneManager.LoadScene("Game");
                break;
        }
    }
    void nextbit()
    {
        dialogCounter = dialogCounter + 1;
    }
}
