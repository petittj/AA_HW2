using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartBegnning()
    {
        SceneManager.LoadScene("Intro");
    }

    public void StartHelp()
    {
        SceneManager.LoadScene("HELP");
    }

}
