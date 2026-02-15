using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Button restart;
    [SerializeField] UnityEngine.UI.Button back;
    [SerializeField] GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        restart.onClick.AddListener(restartmethod);
        back.onClick.AddListener(backmethod);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
        
    }
    void restartmethod()
    {
        SceneManager.LoadScene("Title");
    }
    void backmethod()
    {
        panel.SetActive(false);
    }

}
