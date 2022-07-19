using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class myvideoplayer : MonoBehaviour
{
    [SerializeField] private RawImage rawimage;
    [SerializeField] private VideoPlayer video;
    private QuestionVideo questionvideotoload;
    [SerializeField] private QuestionPool questionfrompoolload;
    bool fullscreen;
    
    // Start is called before the first frame update
    void Start()
    {
        questionvideotoload = questionfrompoolload.question[0];
        video.url = questionvideotoload.CorrectVideo.Englishpath;
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
    }
    public void onpause()
    {
        video.Pause();
    }
    public void onreplay()
    {
        video.Pause();
        video.time = 1;
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
    public void onloadfromlist()
    {
        int rnd;
        rnd = Random.Range(0, questionfrompoolload.question.Count);
        questionvideotoload = questionfrompoolload.question[rnd];
        video.url = questionvideotoload.CorrectVideo.Englishpath;
        StartCoroutine(playvideo());

    }

    
}
