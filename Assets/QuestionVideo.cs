using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
[CreateAssetMenu(fileName = "QuestionVideo", menuName = "Questionvideo")]
public class QuestionVideo : ScriptableObject
{
    public Video CorrectVideo;
    public Video[] PossibleVideo;

}
