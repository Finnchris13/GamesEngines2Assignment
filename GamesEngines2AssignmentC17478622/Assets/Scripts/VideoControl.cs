using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoControl : MonoBehaviour
{

    public GameObject VideoController;

    public float transparentTimer;

    public bool forceSkip;

    public float forceSkipTime;

    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = VideoController.GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += nextScene;
        Invoke("setSeeThrough", transparentTimer);

        if (forceSkip)
        {
            Invoke("forceNextScene", forceSkipTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setSeeThrough()
    {
        var videoPlayer = VideoController.GetComponent<VideoPlayer>();
        videoPlayer.targetCameraAlpha = 0;
    }

    void nextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void forceNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
