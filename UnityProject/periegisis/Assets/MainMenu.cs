using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onstart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void onexit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif 
        Application.Quit();
    }

    public void oninfo()
    {
        print("information is not currently anavable");
    }

    public void onsettings()
    {
        print("Settings are not anavable on current build");
    }

    public void ontutorial()
    {
        print("Tutorial is not ready yet");
    }
    
}
