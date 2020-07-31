using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonManager : MonoBehaviour
{
    public GameObject menuSet;
    public GameObject[] clearStateList;
    public GameManagerLogic manager;
    public static Dictionary<string, bool> clearStateDic;

    void Awake()
    {
        clearCheck();
    }
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
        clearStateDic = new Dictionary<string, bool>();
    }
    public void GameJam()
    {
        SceneManager.LoadScene("GameJamStage");
        clearStateDic = new Dictionary<string, bool>();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void SelectStage1()
    {
        SceneManager.LoadScene("SelectStage1");
    }
    public void SelectStage1_1()
    {
        SceneManager.LoadScene("Stage1-1");
        TimeReset();
    }
    public void SelectStage1_2()
    {
        SceneManager.LoadScene("Stage1-2");
        TimeReset();
    }
    public void SelectStage1_3()
    {
        SceneManager.LoadScene("Stage1-3");
        TimeReset();
    }
    public void SelectStage1_4()
    {
        SceneManager.LoadScene("Stage1-4");
        TimeReset();
    }
    public void SelectStage1_5()
    {
        SceneManager.LoadScene("Stage1-5");
        TimeReset();
    }
    public void SelectStage2()
    {
        SceneManager.LoadScene("SelectStage2");
    }
    public void SelectStage2_1()
    {
        SceneManager.LoadScene("Stage2-1");
        TimeReset();
    }
    public void SelectStage2_2()
    {
        SceneManager.LoadScene("Stage2-2");
        TimeReset();
    }
    public void SelectStage2_3()
    {
        SceneManager.LoadScene("Stage2-3");
        TimeReset();
    }
    public void SelectStage2_4()
    {
        SceneManager.LoadScene("Stage2-4");
        TimeReset();
    }
    public void SelectStage2_5()
    {
        SceneManager.LoadScene("Stage2-5");
        TimeReset();
    }

    public void GameJameSelectStage()
    {
        SceneManager.LoadScene("GameJamStage");
        clearCheck();
    }
    public void GameJamSelectStage1()
    {
        SceneManager.LoadScene("GameJamStage1");
        TimeReset();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void GameExit()
    {
        Application.Quit();
    }

    public void clearCheck()
    {
        if (clearStateDic != null)
        {
            foreach (KeyValuePair<string, bool> pair in clearStateDic)
            {
                foreach (GameObject i in clearStateList)
                {
                    if (pair.Key == i.name && pair.Value == true)
                        i.SetActive(true);
                }
            }
        }
    }

}

