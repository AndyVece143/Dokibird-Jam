using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time = 0.0f;
    public TMP_Text timerText;
    public TMP_Text instructionText;
    public TMP_Text pointsText;
    public int points;
    public string status;
    public Dokibird doki;
    public VidPlayer vidPlayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
        timerText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vidPlayer.startVideo == true)
        {
            time += Time.deltaTime;
            UpdateTimerText();
            CompareStatus();
            TimerCheck();
        }

        if (time >= 193)
        {
            StaticData.endScore = points;
            SceneManager.LoadScene("Results");
        }
    }

    private void CompareStatus()
    {
        if (status != "freestyle")
        {
            if (doki.status == status)
            {
                points += 1;
            }
        }

        if (status == "freestyle")
        {
            if (doki.status != "idle")
            {
                points += 1;
            }
        }

        pointsText.text = "Points: " + points.ToString();
    }
    private void ChangeStatus(string emote)
    {
        status = emote;
        if (emote != "null")
        {
            instructionText.enabled = true;

            switch(emote)
            {
                case "sideeye":
                    instructionText.text = "Hit 'em with the side eye!";
                    break;

                case "crying":
                    instructionText.text = "Start crying!";
                    break;

                case "freestyle":
                    instructionText.text = "React however you want!";
                    break;
                default:
                    instructionText.text = "Act " + emote;
                    break;
            }


        }
        else
        {
            instructionText.enabled = false;
        }
    }

    private void TimerCheck()
    {
        ChangeStatus("null");
        if (time >= 3 && time <= 7)
        {
            ChangeStatus("suprised");
        }

        if (time >= 9 && time <= 12)
        {
            ChangeStatus("neutral");
        }

        if (time >= 17 && time <= 30)
        {
            ChangeStatus("suprised");
        }

        if (time >= 34 && time <= 50)
        {
            ChangeStatus("freestyle");
        }

        if (time >= 54 && time <= 60)
        {
            ChangeStatus("neutral");
        }

        if (time >= 64 && time <= 67)
        {
            ChangeStatus("sideeye");
        }

        if (time >= 71 && time <= 76)
        {
            ChangeStatus("excited");
        }

        if (time >= 79 && time <= 82)
        {
            ChangeStatus("angry");
        }

        if (time >= 90 && time <= 92)
        {
            ChangeStatus("sideeye");
        }

        if (time >= 95 && time <= 102)
        {
            ChangeStatus("crying");
        }

        if (time >= 109 && time <= 114)
        {
            ChangeStatus("shocked");
        }

        if (time >= 117 && time <= 122)
        {
            ChangeStatus("neutral");
        }

        if (time >= 129 && time <= 132)
        {
            ChangeStatus("excited");
        }

        if (time >= 136 && time <= 140)
        {
            ChangeStatus("shocked");
        }

        if (time >= 141 && time <= 144)
        {
            ChangeStatus("excited");
        }

        if (time >= 146 && time <= 149)
        {
            ChangeStatus("shocked");
        }

        if (time >= 152 && time <= 155)
        {
            ChangeStatus("freestyle");
        }

        if (time >= 158 && time <= 166)
        {
            ChangeStatus("disgusted");
        }

        if (time >= 170 && time <= 173)
        {
            ChangeStatus("excited");
        }

        if (time >= 178 && time <= 181)
        {
            ChangeStatus("sideeye");
        }

        if (time >= 183 && time <= 193)
        {
            ChangeStatus("crying");
        }

        //else
        //{
        //    ChangeStatus("null");
        //}
    }

    private void UpdateTimerText()
    {
        int seconds = ((int)time % 60);
        int minutes = ((int)time / 60);

        string formatedTime = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = formatedTime;
    }
}
