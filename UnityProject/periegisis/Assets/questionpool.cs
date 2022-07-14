using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
[CreateAssetMenu(fileName = "QuestionPool", menuName = "QuestionPool")]
public class QuestionPool : ScriptableObject
{
    public List<QuestionVideo> question = new List<QuestionVideo>();

}
