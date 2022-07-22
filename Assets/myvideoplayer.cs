using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class myvideoplayer : MonoBehaviour
{
    //GameObjects
    [SerializeField] private GameObject losetext;
    [SerializeField] private GameObject wintext;
    [SerializeField] private GameObject buttoncontroller;
    [SerializeField] private GameObject choosen;
    [SerializeField] private GameObject choosen2;
    [SerializeField] private GameObject rooms;
    [SerializeField] private GameObject imagecontroller;
    [SerializeField] private GameObject centerplace;
    //rawimage
    [SerializeField] private RawImage rawimage;
    [SerializeField] private RawImage rawimage2;
    //video
    [SerializeField] private VideoPlayer video;
    [SerializeField] private VideoPlayer video2;
    
    private QuestionVideo questionvideotoload;
    private GameObject test;
    [SerializeField] private QuestionPool questionfrompoolload;
    bool fullscreen;
    bool continiue;
    bool correct1 = true;
 
    
    // Start is called before the first frame update
    void Start()
    {
        initialization();

    }
    IEnumerator playvideo()
    {
        video.Prepare();
        video2.Prepare();
        WaitForSeconds waitforseconds = new WaitForSeconds(1);
        while (!video.isPrepared)
        {
            yield return waitforseconds;
            break;
        }
        rawimage.texture = video.texture;
        rawimage2.texture = video2.texture;
        video.Play();
        video.Pause();
        video.time = 0;
        video2.Play();
        video2.Pause();
        video2.time = 0;

    }
    //Start Buttons for Video 1 and 2
    public void onstart()
    {
        if (correct1 == true)
        {
            video.Play();
        }
        else
        {
            video2.Play();
        }
       
    }
    public void onstart2()
    {
        if (correct1 == true)
        {
            video2.Play();
        }
        else
        {
            video.Play();
        }
        
    }
    //Pause Buttons for Video 1 and 2
    public void onpause()
    {
        if (correct1 == true)
        {
            video.Pause();
        }
        else
        {
            video2.Pause();
        }
      
    }
    public void onpause2()
    {
        if (correct1 == true)
        {
            video2.Pause();
        }
        else
        {
            video.Pause();
        }
       
    }
    //Replay for Video 1 and 2
    public void onreplay()
    {
        if (correct1 == true)
        {
            video.Pause();
            video.time = 0;
        }
        else
        {
            video2.Pause();
            video2.time = 0;
        }
       
    }
    public void onreplay2()
    {
        if (correct1 == true)
        {
            video2.Pause();
            video2.time = 0;
        }
        else
        {
            video.Pause();
            video.time = 0;
        }
       
    }
    //Fullscreen for video 1 and 2
    public void onfullscreen()
    {
        if (correct1 == true)
        {
            if (fullscreen == false)
            {
                if (continiue == true)
                {
                    choosen.transform.position = choosen.transform.position + new Vector3(0, -2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(+500, 0, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, -2000, 0);
                }
                rawimage.rectTransform.sizeDelta = new Vector2(1920, 1080);
                fullscreen = true;

            }
            else
            {
                if (continiue == true)
                {
                    choosen.transform.position = choosen.transform.position + new Vector3(0, +2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(-500, 0, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, +2000, 0);
                }
                rawimage.rectTransform.sizeDelta = new Vector2(900, 600);
                fullscreen = false;
            }
        }
        else
        {
            if (fullscreen == false)
            {
                if (continiue == true)
                {
                    choosen2.transform.position = choosen2.transform.position + new Vector3(0, -2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(0, -2000, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(-500, 0, 0);
                }
                rawimage2.rectTransform.sizeDelta = new Vector2(1920, 1080);
                fullscreen = true;
            }
            else
            {
                if (continiue == true)
                {
                    choosen2.transform.position = choosen2.transform.position + new Vector3(0, +2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(0, +2000, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(+500, 0, 0);
                }
                rawimage2.rectTransform.sizeDelta = new Vector2(900, 600);
                fullscreen = false;
            }
        }
        
        
    }
    public void onfullscreen2()
    {
        if (correct1 == true)
        {
            if (fullscreen == false)
            {
                if (continiue == true)
                {
                    choosen2.transform.position = choosen2.transform.position + new Vector3(0, -2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(0, -2000, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(-500, 0, 0);
                }
                rawimage2.rectTransform.sizeDelta = new Vector2(1920, 1080);
                fullscreen = true;
            }
            else
            {
                if (continiue == true)
                {
                    choosen2.transform.position = choosen2.transform.position + new Vector3(0, +2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(0, +2000, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(+500, 0, 0);
                }
                rawimage2.rectTransform.sizeDelta = new Vector2(900, 600);
                fullscreen = false;
            }
        }
        else
        {
            if (fullscreen == false)
            {
                if (continiue == true)
                {
                    choosen.transform.position = choosen.transform.position + new Vector3(0, -2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(+500, 0, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, -2000, 0);
                }
                rawimage.rectTransform.sizeDelta = new Vector2(1920, 1080);
                fullscreen = true;

            }
            else
            {
                if (continiue == true)
                {
                    choosen.transform.position = choosen.transform.position + new Vector3(0, +2000, 0);
                    rawimage.transform.position = rawimage.transform.position + new Vector3(-500, 0, 0);
                    rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, +2000, 0);
                }
                rawimage.rectTransform.sizeDelta = new Vector2(900, 600);
                fullscreen = false;
            }
        }
        
    }
    public void onloadfromlist()
    {
        int rnd = Random.Range(0, questionfrompoolload.question.Count);
        questionvideotoload = questionfrompoolload.question[rnd];

        int j = Random.Range(0, questionvideotoload.PossibleVideo.Length);
        video.url = questionvideotoload.CorrectVideo.Englishpath;
        video2.url = questionvideotoload.PossibleVideo[j].Englishpath;
        StartCoroutine(playvideo());
    }
        
    public void oncontinue()
    {
        if (fullscreen == true)
        {
            rawimage.rectTransform.sizeDelta = new Vector2(900, 600);
            fullscreen = false;
        }
        choosen.SetActive(true);
        choosen2.SetActive(true);
        rawimage.transform.position = rawimage.transform.position + new Vector3(-500, 0, 0);
        rawimage2.transform.position = rawimage2.transform.position + new Vector3(-1000, 0, 0);
        continiue = true;
        buttoncontroller.SetActive(false);
        int i = Random.Range(0, 2);
        if (i == 1)
        {
            correct1 = true;
            rawimage.texture = video.texture;
            rawimage2.texture = video2.texture;
        }
        else
        {
            correct1 = false;
            rawimage.texture = video2.texture;
            rawimage2.texture = video.texture;
        }
        video.Play();
        video.time = 0;
        video.Pause();
        video2.time = 0;

    }
    public void onchoose()
    {
        if (correct1 == true)
        {
            wintext.transform.position = wintext.transform.position + new Vector3(+1200, 0, 0);
            rawimage.transform.position = rawimage.transform.position + new Vector3(0, -2000, 0);
            rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, -2000, 0);
            print("correct!");
        }
        else
        {
            losetext.transform.position = losetext.transform.position + new Vector3(-1200, 0, 0);
            rawimage.transform.position = rawimage.transform.position + new Vector3(0, -2000, 0);
            rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, -2000, 0);
            print("wrong");
        }
    }
    public void onchoose2()
    {
        if (correct1 == false)
        {
            wintext.transform.position = wintext.transform.position + new Vector3(+1200, 0, 0);
            rawimage.transform.position = rawimage.transform.position + new Vector3(0, -2000, 0);
            rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, -2000, 0);
            print("correct");
        }
        else
        {
            losetext.transform.position = losetext.transform.position + new Vector3(-1200, 0, 0);
            rawimage.transform.position = rawimage.transform.position + new Vector3(0, -2000, 0);
            rawimage2.transform.position = rawimage2.transform.position + new Vector3(0, -2000, 0);
            print("wrong");
        }

    }
    //LoadQuestionPools
    public void loadpoolroom1()
    {
        rooms.SetActive(false);
        buttoncontroller.SetActive(true);
        imagecontroller.SetActive(true);
        questionfrompoolload = Resources.Load<QuestionPool>("QuestionPool");
        int i = Random.Range(0, 3);
        questionvideotoload = questionfrompoolload.question[i];
        int j = Random.Range(0, questionvideotoload.PossibleVideo.Length);
        video.url = questionvideotoload.CorrectVideo.Englishpath;
        video2.url = questionvideotoload.PossibleVideo[j].Englishpath;
        StartCoroutine(playvideo());
    }
    
    public void loadpoolroom2()
    {
        rooms.SetActive(false);
        buttoncontroller.SetActive(true);
        imagecontroller.SetActive(true);
        questionfrompoolload = Resources.Load<QuestionPool>("QuestionPool 1");
        int i = Random.Range(0, 3);
        questionvideotoload = questionfrompoolload.question[i];
        int j = Random.Range(0, questionvideotoload.PossibleVideo.Length);
        video.url = questionvideotoload.CorrectVideo.Englishpath;
        video2.url = questionvideotoload.PossibleVideo[j].Englishpath;
        StartCoroutine(playvideo());

    }
    public void loadpoolroom3()
    {
        rooms.SetActive(false);
        buttoncontroller.SetActive(true);
        imagecontroller.SetActive(true);
        questionfrompoolload = Resources.Load<QuestionPool>("QuestionPool 2");
        int i = Random.Range(0, 3);
        questionvideotoload = questionfrompoolload.question[i];
        int j = Random.Range(0, questionvideotoload.PossibleVideo.Length);
        video.url = questionvideotoload.CorrectVideo.Englishpath;
        video2.url = questionvideotoload.PossibleVideo[j].Englishpath;
        StartCoroutine(playvideo());

    }
    public void loadpoolroom4()
    {
        rooms.SetActive(false);
        buttoncontroller.SetActive(true);
        imagecontroller.SetActive(true);
        questionfrompoolload = Resources.Load<QuestionPool>("QuestionPool 3");
        int i = Random.Range(0, 3);
        questionvideotoload = questionfrompoolload.question[i];
        int j = Random.Range(0, questionvideotoload.PossibleVideo.Length);
        video.url = questionvideotoload.CorrectVideo.Englishpath;
        video2.url = questionvideotoload.PossibleVideo[j].Englishpath;
        StartCoroutine(playvideo());

    }
    public void initialization()
    {
        choosen.SetActive(false);
        choosen2.SetActive(false);
        continiue = false;
        fullscreen = false;
        buttoncontroller.SetActive(false);
        imagecontroller.SetActive(false);
        rooms.transform.position = centerplace.transform.position; 

        //StartCoroutine(playvideo());

    }



}
