using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDialog : MonoBehaviour
{
    [SerializeField] string[] dialog = { "D1", "D2", "D3" };

    [SerializeField] int numSuccess;
    [SerializeField] TextMeshProUGUI text1;
    // Start is called before the first frame update
    void Start()
    {
        numSuccess = StaticData.correctGuesses;
    }

    // Update is called once per frame
    void Update()
    {
        switch (numSuccess){
            case 0:
                text1.text = dialog[1];
                break;
            case 1:
                text1.text = dialog[2];
                break;
            case 2:
                text1.text = dialog[3];
                break;
        }
    }
}
