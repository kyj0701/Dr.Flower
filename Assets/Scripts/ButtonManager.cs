using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonManager : MonoBehaviour
{
    public GameObject menuSet;
    public GameManagerLogic manager;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
                TimeReset();
            }
            else
            {
                menuSet.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void TimeReset()
    {
        Time.timeScale = 1;
    }
    public void GameStart()
    {
        SceneManager.LoadScene("Stage0");
    }
    public void Restart()
    {
        SceneManager.LoadScene(manager.stageLevel);
    }
    public void SelectStage1()
    {
        SceneManager.LoadScene("SelectStage1");
    }
    public void SelectStage1_1()
    {
        SceneManager.LoadScene("Stage1-1");
    }
    public void SelectStage1_2()
    {
        SceneManager.LoadScene("Stage1-2");
    }
    public void SelectStage1_3()
    {
        SceneManager.LoadScene("Stage1-3");
    }
    public void SelectStage1_4()
    {
        SceneManager.LoadScene("Stage1-4");
    }
    public void SelectStage1_5()
    {
        SceneManager.LoadScene("Stage1-5");
    }
    /*public void SelectStage2()
    {
        SceneManager.LoadScene("SelectStage2");
    }
    public void SelectStage2_1()
    {
        SceneManager.LoadScene("Stage2-1");
    }
    public void SelectStage2_2()
    {
        SceneManager.LoadScene("Stage2-2");
    }
    public void SelectStage2_3()
    {
        SceneManager.LoadScene("Stage2-3");
    }
    public void SelectStage2_4()
    {
        SceneManager.LoadScene("Stage2-4");
    }
    public void SelectStage2_5()
    {
        SceneManager.LoadScene("Stage2-5");
    }*/
    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
