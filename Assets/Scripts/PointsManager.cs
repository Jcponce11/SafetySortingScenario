using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PointsManager : MonoBehaviour
{

    public Text scoreText;
    public Text messageText;
    private int Points;
    private int negaPoints;
    // public float time = 5;
    public Text scenarioMessageText;
    static AudioSource audiosrc;
    public AudioClip FogHorn;
    public AudioClip Success;
    public Destructable destroyer;
    int objectCount;


    public void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        Points = 0;
        negaPoints = 0; //These are negative points. Don't forget these when creating a scoreboard.
        //scoreText.text = "score:" + Points;
        ScenarioMessage("You walk into a patient's room to find leftover supplies from a recent blood draw. " +
           "There are sharps, biohazards, and trash that must be disposed of. The patient is in the restroom " +
            " but will return shortly. Place each item in the appropriate recepticle: Trash, Biohazard Bin, or Sharps container.");
        StartCoroutine(HideScenarioText());
    }

    private void Update()
    { 
    }

   

    public void AddPoints(int amount)
    {
        Points = Points + amount;
        audiosrc.PlayOneShot(Success);
        scoreText.text = "score: " + Points;
        StartCoroutine(HideScoreText());
        
    }

    public void WarningMessage(string other1)
    {
        negaPoints = negaPoints + 1;
        messageText.text = other1;
        Debug.Log(other1);
        audiosrc.PlayOneShot(FogHorn);
        StartCoroutine(HideMessageText());
    }

    public void ScenarioMessage(string other)
    {
        scenarioMessageText.text = other;
        StartCoroutine(HideScenarioText());
    }

    IEnumerator HideScoreText()
    {
        yield return new WaitForSeconds(5);
        GetComponent<PointsManager>().scoreText.text = "";

    }

    IEnumerator HideMessageText()
    {
        yield return new WaitForSeconds(5);
        GetComponent<PointsManager>().messageText.text = "";
    }

    IEnumerator HideScenarioText()
    {
        yield return new WaitForSeconds(15);
        GetComponent<PointsManager>().scenarioMessageText.text = "";
    }

    IEnumerator ExitScreen()
    {
        GetComponent<PointsManager>().scenarioMessageText.text = Points.ToString();
        yield return new WaitForSeconds(10);
        Application.Quit();

    }
}