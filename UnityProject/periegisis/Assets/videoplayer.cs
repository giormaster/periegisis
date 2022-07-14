using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoplayer : MonoBehaviour
{
    [SerializeField] private RawImage rawimage;
    [SerializeField] private VideoPlayer video;
    [SerializeField] private AudioSource audio;
    bool fullscreen;
    // Start is called before the first frame update
    void Start()
    {
        fullscreen = false;
        StartCoroutine(playvideo());
    }
    IEnumerator playvideo()
    {
        video.Prepare();
        WaitForSeconds waitforseconds = new WaitForSeconds(1);
        while (!video.isPrepared)
        {
            yield return waitforseconds;
            break;
        }
        rawimage.texture = video.texture;
        
    }
    public void onstart()
    {
        video.Play();
        audio.Play();
    }
    public void onpause()
    {
        video.Pause();
        audio.Pause();
    }
    public void onreplay()
    {
        video.Pause();
        audio.Pause();
        video.time = 1;
        audio.time = 1;
    }
    public void onfullscreen()
    {
        if (fullscreen == false)
        {
            rawimage.rectTransform.sizeDelta = new Vector2(1920, 1080);
            fullscreen = true;
        }
        else
        {
            rawimage.rectTransform.sizeDelta = new Vector2(900, 600);
            fullscreen = false;
        }
        
    }

    
}
