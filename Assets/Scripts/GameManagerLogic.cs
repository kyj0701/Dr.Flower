using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    public int stageLevel;
    public Text stageCountText;
    public Text playerCountText;

    void Awake()
    {
        stageCountText.text = "/ " + totalItemCount;
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }
}
