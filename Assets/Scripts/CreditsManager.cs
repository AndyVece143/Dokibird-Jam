using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
