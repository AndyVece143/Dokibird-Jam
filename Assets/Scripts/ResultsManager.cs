using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultsManager : MonoBehaviour
{
    public TMP_Text pointsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = StaticData.endScore.ToString();
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
