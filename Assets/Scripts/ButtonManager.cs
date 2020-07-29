using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject menuSet;
    public GameManagerLogic manager;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
                menuSet.SetActive(false);
            else
                menuSet.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(manager.stageLevel);
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
    public void GameExit()
    {
        Application.Quit();
    }
}
