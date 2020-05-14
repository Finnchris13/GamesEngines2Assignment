using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour
{

    public GameObject VideoController;

    public float transparentTimer;

    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = VideoController.GetComponent<UnityEngine.Video.VideoPlayer>();
        Invoke("setSeeThrough", transparentTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setSeeThrough()
    {
        var videoPlayer = VideoController.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.targetCameraAlpha = 0;
    }

}
