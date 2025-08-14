using UnityEngine;
using UnityEngine.Video;

public class VideoPlayingScript : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    private float time = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 5.0f)
        {
            videoPlayer.Play();
        }
    }
}
