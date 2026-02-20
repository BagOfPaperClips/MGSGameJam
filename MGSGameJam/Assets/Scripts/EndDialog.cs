using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndDialog : MonoBehaviour
{
    [SerializeField] string[] dialog = { "You’ll be sleepin’ with the fishes tonight.", "Seems this one ain’t so bright.", "Oof! Be glad I paid you in advance.", "Oooh, baby, we're having dinner tonight!" };

    [SerializeField] int numSuccess;
    [SerializeField] TextMeshProUGUI text1;
    [SerializeField] AudioSource a1;
    [SerializeField] AudioSource a2;
    [SerializeField] AudioSource a3;
    [SerializeField] AudioSource a4;

    bool audioOn = false;

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
            text1.text = "You ran out of money? What a bloody fool...";
        }
        else
        {
            switch (numSuccess)
            {
                case 0:
                    if (audioOn == false)
                    {
                        a1.Play();
                        audioOn = true;
                    }
                    
                        text1.text = dialog[0];
                    break;
                case 1:
                    if (audioOn == false)
                    {
                        a2.Play();
                        audioOn = true;
                    }
                    text1.text = dialog[1];
                    break;
                case 2:
                    if (audioOn == false)
                    {
                        a3.Play();
                        audioOn = true;
                    }
                    text1.text = dialog[2];
                    break;
                case 3:
                    if(audioOn == false)
                    {
                        a4.Play();
                        audioOn = true;
                    }
                    text1.text = dialog[3];
                    break;


            }
        }
        
    }

    public void BacktoMenu()
    {
        a1.Stop();
        a2.Stop();
        a3.Stop();
        a4.Stop();
        SceneManager.LoadScene("Title");
    }
}
