using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialDialog : MonoBehaviour
{
    [SerializeField] int dialogCounter = 0;
    public string[] dialog = { "D1", "D2", "D3","D4" };
    [SerializeField] TextMeshProUGUI textObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (dialogCounter)
        {
            case 0:
                textObj.text = dialog[0];

                break;
        }
    }
}
