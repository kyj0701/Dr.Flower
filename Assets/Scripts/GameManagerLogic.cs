using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    public Text stageCountText;
    public Text playerCountText;
    public GameObject dieSet;
    public GameObject dontClearSet;
    private new AudioSource audio;

    void Awake()
    {
        stageCountText.text = "/ " + totalItemCount;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(dontClearSet.activeSelf == true || dieSet.activeSelf == true)
        {
            audio.Stop();
        }
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            dieSet.SetActive(true);
        }
    }
}
