using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
[CreateAssetMenu(fileName = "Questionpool", menuName = "Question_pool")]
public class questionpool : ScriptableObject
{
    public VideoPlayer[] questions;
    public void ondelete()
    {
        questions = null;
    }

}
