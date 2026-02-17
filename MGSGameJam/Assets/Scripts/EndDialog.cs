using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDialog : MonoBehaviour
{
    [SerializeField] string[] dialog = { "You’ll be sleepin’ with the fishes tonight.", "Seems this one ain’t so bright.", "Oof! Be glad I paid you in advance.", "Oooh, baby, we're having dinner tonight!" };

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
        if (StaticData.balance <= 0)
        {
            text1.text = "You ran out of money? What a bloody fool";
        }
        else
        {
            switch (numSuccess)
            {
                case 0:
                    text1.text = dialog[0];
                    break;
                case 1:
                    text1.text = dialog[1];
                    break;
                case 2:
                    text1.text = dialog[2];
                    break;
                case 3:
                    text1.text = dialog[3];
                    break;
            }
        }
        
    }
}
