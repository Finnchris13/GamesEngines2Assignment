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

    public GameObject UIOverlay;

    public bool activateOverlay;

    public float overlayTimeOne;
    public float overlayOffTimeOne;
    public float overlayTimeTwo;
    public float overlayOffTimeTwo;

    public bool sceneTwo;

    public float transparentOffOne;
    public float transparentOnTwo;
    public float transparentOffTwo;

    public BigBoid boidScript;

    public bool accessBoid;

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

        if (activateOverlay)
        {
            UIOverlay.SetActive(false);
            Invoke("enableOverlayOne", overlayTimeOne);
        }

        if (accessBoid)
        {
            boidScript.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enableOverlayOne()
    {
        UIOverlay.SetActive(true);
        boidScript.enabled = true;
        Invoke("disableOverlayOne", overlayOffTimeOne);
    }

    void disableOverlayOne()
    {
        UIOverlay.SetActive(false);
        Invoke("enableOverlayTwo", overlayTimeTwo);
    }

    void enableOverlayTwo()
    {
        UIOverlay.SetActive(true);
        Invoke("disableOverlayTwo", overlayOffTimeTwo);
    }

    void disableOverlayTwo()
    {
        UIOverlay.SetActive(false);
    }

    void setSeeThrough()
    {
        var videoPlayer = VideoController.GetComponent<VideoPlayer>();
        videoPlayer.targetCameraAlpha = 0;

        if (sceneTwo)
        {
            Invoke("turnAlphaUpOne", transparentOffOne);
        }
    }

    void turnAlphaUpOne()
    {
        var videoPlayer = VideoController.GetComponent<VideoPlayer>();
        videoPlayer.targetCameraAlpha = 1;
        Invoke("setSeeThroughTwo", transparentOnTwo);
    }

    void setSeeThroughTwo()
    {
        var videoPlayer = VideoController.GetComponent<VideoPlayer>();
        videoPlayer.targetCameraAlpha = 0;
        Invoke("turnAlphaUpTwo", transparentOffTwo);
    }

    void turnAlphaUpTwo()
    {
        var videoPlayer = VideoController.GetComponent<VideoPlayer>();
        videoPlayer.targetCameraAlpha = 1;
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
