using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background: MonoBehaviour
{
    public float speed;
    public int startIndex;
    public int endIndex;
    public Transform[] sprites;

    float viewHeight;

    private void Awake()
    {
        viewHeight = 995;
    }

    void Update()
    {
        Vector3 curPos = transform.position;
        Vector3 nextPos = Vector3.left * speed * Time.deltaTime;
        transform.position = curPos + nextPos;

        if (sprites[endIndex].position.x < viewHeight * (-1))
        {
            Vector3 backSpritePos = sprites[startIndex].localPosition;
            Vector3 fronSpritePos = sprites[endIndex].localPosition;

            sprites[endIndex].transform.localPosition = backSpritePos + Vector3.right * viewHeight;

            int startIndexSave = startIndex;
            startIndex = endIndex;
            endIndex = (startIndexSave -1  == -1) ? sprites.Length-1 : startIndexSave - 1;
        }
    }
}
