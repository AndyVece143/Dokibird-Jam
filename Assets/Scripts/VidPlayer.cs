using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.Video;
public class VidPlayer : MonoBehaviour
{
    [SerializeField] string videoFileName;
    VideoPlayer videoPlayer;
    private int i = 0;
    private float time = 0.0f;
    public bool startVideo = false;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
        Debug.Log(videoPath);
        videoPlayer.url = videoPath;
        videoPlayer.prepareCompleted += OnPrepareCompleted;
        videoPlayer.playOnAwake = false;
    }

    void OnPrepareCompleted(VideoPlayer videoPlayer)
    {
        Debug.Log("Play");

    }

    private void Update()
    {

        if (!videoPlayer.isPrepared)
        {
            i++;
            Debug.Log(i);
            videoPlayer.Prepare();
        }

        time += Time.deltaTime;
        if (time >= 4.0f)
        {
            videoPlayer.Play();
            startVideo = true;
        }
    }
}

    //void Start()
    //{
    //    PlayVideo();
    //}

    //public void PlayVideo()
    //{
    //    VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
    //    if (videoPlayer)
    //    {
    //        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
    //        Debug.Log(videoPath);
    //        videoPlayer.url = videoPath;
    //        videoPlayer.Play();
    //    }
    //}

