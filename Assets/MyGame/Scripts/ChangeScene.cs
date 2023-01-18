using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void SceneChange()
    {
        SceneManager.LoadScene(0);
    }

    public void SceneChangeStart()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneChangeSettings()
    {
        SceneManager.LoadScene(2);
    }

    public void SceneChangeOptions()
    {
        SceneManager.LoadScene(2);
    }

    public void SceneChangeInfo()
    {
        SceneManager.LoadScene(5);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Manager.presentCounter = 0;
        GameState.instance.Done = 0;
    }

}
