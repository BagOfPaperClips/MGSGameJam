using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CupMixerChallenge : MonoBehaviour
{
    [Header("UI Settings")]
    public TMP_Text counterTxt;
    public TMP_Text numberOfStrikes;
    public Image prizeIndicator;

    [Header("Game Settings")]
    public GameObject[] cups;
    public float liftHeight = 150f;
    public int totalRounds = 3;
    public float moveDuration = 0.5f; // How long a move takes in seconds

    [Header("Sprites")]
    public Sprite standingCup;
    public Sprite layingCup;

    private int score = 0;
    private int strikes = 0;

    private bool isShuffling = false;
    private Vector3[] startPositions;

    void Start()
    {
        score = 0;
        strikes = 0;
        UpdateCounterUI();
        prizeIndicator.enabled = false;

        // Stores the starting positions of the cups so we know where they belong
        startPositions = new Vector3[cups.Length];
        for (int i = 0; i < cups.Length; i++)
        {
            startPositions[i] = cups[i].transform.position;
        }

        StartCoroutine(GameLoop());
    }

    IEnumerator GameLoop()
    {
        isShuffling = true;
        ToggleButtons(false); // Disable clicking while shuffling

        // 1. Reveal the prize initially
        foreach (GameObject cup in cups)
        {
            StartCoroutine(AnimateCupReveal(cup, true));
        }
        yield return new WaitForSeconds(1.5f);

        // 2. Shuffle Loop
        for (int i = 0; i < totalRounds; i++)
        {
            // Lift cups up
            yield return MoveAllCups(Vector3.up * liftHeight);

            // Shuffle the positions array
            Vector3[] shuffledPositions = CupMixerExtensions.ShuffleArray(startPositions);

            // Move cups to their new random slots
            List<Coroutine> activeMoves = new List<Coroutine>();
            for (int k = 0; k < cups.Length; k++)
            {
                Vector3 targetPos = new Vector3(shuffledPositions[k].x, cups[k].transform.position.y, cups[k].transform.position.z);
                activeMoves.Add(StartCoroutine(cups[k].SmoothMove(targetPos, moveDuration)));
            }

            // Wait for all cups to finish moving horizontally
            foreach (var c in activeMoves) yield return c;

            // Put cups back down
            yield return MoveAllCups(Vector3.down * liftHeight);

            // Short pause between shuffles
            yield return new WaitForSeconds(0.2f);
        }

        ToggleButtons(true);
        isShuffling = false;
    }

    // Helper to move all cups at once by a specific offset
    IEnumerator MoveAllCups(Vector3 offset)
    {
        List<Coroutine> moves = new List<Coroutine>();
        foreach (GameObject cup in cups)
        {
            moves.Add(StartCoroutine(cup.SmoothMove(cup.transform.position + offset, moveDuration)));
        }
        // Wait until the animation finishes
        foreach (var m in moves) yield return m;
    }

    public void OnCupClicked(GameObject selectedCup)
    {
        Debug.Log("Button was clicked!", this);

        if (isShuffling) return;

        StartCoroutine(AnimateCupReveal(selectedCup, false));

        // Check if this cup has the Prize
        Image[] images = selectedCup.GetComponentsInChildren<Image>();
        bool hasPrize = images.Length > 1;

        if (hasPrize)
        {
            score++;
            StartCoroutine(FlashCounter(Color.green));
        }
        else
        {
            //score = 0;
            strikes++;
            UpdateStrikesUI();
            StartCoroutine(FlashCounter(Color.red));
        }
        UpdateCounterUI();

        if (score < 3 && strikes < 3)
        {
            StartCoroutine(GameLoop());
        }
        else
        {
            ToggleButtons(false);

            if (score == 3)
            {
                ChallengeComplete();
            }
            if (strikes == 3)
            {
                ChallengeFailed();
            }
        }
    }

    IEnumerator AnimateCupReveal(GameObject cup, bool showPrizeIndicator)
    {
        Image cupImg = cup.GetComponent<Image>();

        // Open the cup
        cupImg.sprite = layingCup;
        if (showPrizeIndicator) prizeIndicator.enabled = true;

        yield return new WaitForSeconds(1f);

        // Close the cup
        cupImg.sprite = standingCup;
        if (showPrizeIndicator) prizeIndicator.enabled = false;
    }

    void UpdateCounterUI() => counterTxt.text = "Counter: " + score;

    IEnumerator FlashCounter(Color color)
    {
        counterTxt.color = color;
        yield return new WaitForSeconds(0.5f);
        counterTxt.color = Color.white;
    }

    void UpdateStrikesUI() => numberOfStrikes.text = "Strikes: " + strikes;

    void ToggleButtons(bool state)
    {
        foreach (GameObject c in cups)
        {
            Button b = c.GetComponent<Button>();
            if (b != null) b.interactable = state;
        }
    }

    void ChallengeComplete()
    {

    }

    void ChallengeFailed()
    {
        SceneManager.LoadScene("Game");
    }
}
