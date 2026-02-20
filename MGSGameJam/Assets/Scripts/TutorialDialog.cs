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
    [SerializeField] AudioSource yap;

    bool soundstart = false;
    // Start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(nextbit);
        yap.Play();
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
                if (soundstart == false)
                {
                    soundstart = true;
                    yap.Stop();
                    yap.Play();
                }
                
                break;
            case 2:
                textObj.text = dialog[2];
                if (soundstart == true)
                {
                    soundstart = false;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 3:
                textObj.text = dialog[3];
                if (soundstart == false)
                {
                    soundstart = true;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 4:
                textObj.text = dialog[4];
                if (soundstart == true)
                {
                    soundstart = false;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 5:
                textObj.text = dialog[5];
                if (soundstart == false)
                {
                    soundstart = true;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 6:
                textObj.text = dialog[6];
                if (soundstart == true)
                {
                    soundstart = false;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 7:
                textObj.text = dialog[7];
                if (soundstart == true)
                {
                    soundstart = false;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 8:
                textObj.text = dialog[8];
                if (soundstart == true)
                {
                    soundstart = false;
                    yap.Stop();
                    yap.Play();
                }

                break;
            case 9:
                SceneManager.LoadScene("Game");

                break;
                
        }
    }
    void nextbit()
    {
        dialogCounter = dialogCounter + 1;
    }
}
