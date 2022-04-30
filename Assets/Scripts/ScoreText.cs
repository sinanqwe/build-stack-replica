using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        GameManager.OnCubeSparwned += GameManager_OnCubeSparwned;
    }
    private void OnDestroy()
    {
        GameManager.OnCubeSparwned -= GameManager_OnCubeSparwned;
    }

    private void GameManager_OnCubeSparwned()
    {
        score++;
        text.text = "Score : " + score;
    }

}
