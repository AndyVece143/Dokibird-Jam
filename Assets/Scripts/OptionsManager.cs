using UnityEngine;

using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public SpriteRenderer dokiGreen;
    public SpriteRenderer dokiRed;

    public Toggle toggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toggle.isOn = StaticData.valueToKeep;
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle.isOn == true)
        {
            dokiGreen.color = Color.gray;
            dokiRed.color = Color.white;
            Debug.Log("button on");
        }

        else
        {
            dokiGreen.color = Color.white;
            dokiRed.color = Color.gray;
            Debug.Log("button off");
        }

        //Store Color Data
        StaticData.valueToKeep = toggle.isOn;
    }


}
