using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM1 : MonoBehaviour
{
    public AudioSource gameSong;

    // Start is called before the first frame update
    void Start()
    {
        gameSong = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        gameSong.enabled =
            SceneManager.GetActiveScene().name.Equals("ActionTime") ||
            SceneManager.GetActiveScene().name.Equals("CupMixingChallenge") ||
            SceneManager.GetActiveScene().name.Equals("TutorialScene") ||
            SceneManager.GetActiveScene().name.Equals("Game") ||
            SceneManager.GetActiveScene().name.Equals("Credits") ||
            SceneManager.GetActiveScene().name.Equals("Help") ||
            SceneManager.GetActiveScene().name.Equals("Title");
    }
}
