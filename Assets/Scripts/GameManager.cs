using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float time = 0.0f;
    public TMP_Text timerText;
    public TMP_Text instructionText;
    public TMP_Text pointsText;
    public int points;
    public string status;
    public Dokibird doki;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        UpdateTimerText();
        CompareStatus();
        TimerCheck();
    }

    private void CompareStatus()
    {
        if (doki.status == status)
        {
            points += 1;
        }
        pointsText.text = "Points: " + points.ToString();
    }
    private void ChangeStatus(string emote)
    {
        status = emote;
        if (emote != "null")
        {
            instructionText.enabled = true;
            instructionText.text = "Act " + emote;
        }
        else
        {
            instructionText.enabled = false;
        }
    }

    private void TimerCheck()
    {
        if (time >= 5 && time <= 10)
        {
            ChangeStatus("suprised");
        }
        else
        {
            ChangeStatus("null");
        }
    }

    private void UpdateTimerText()
    {
        int seconds = ((int)time % 60);
        int minutes = ((int)time / 60);

        string formatedTime = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = formatedTime;
    }
}
