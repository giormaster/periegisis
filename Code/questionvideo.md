using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
[CreateAssetMenu(fileName = "Questionvideo_list", menuName = "Questionvideo")]
public class QuestionVideo : ScriptableObject
{
    public VideoPlayer questionvideo;
    public VideoPlayer[] videolist;

    
}
