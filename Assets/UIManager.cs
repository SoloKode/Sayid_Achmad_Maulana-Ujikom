using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text UIText;
    private TimeElapsed time;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        time = TimeElapsed.instance;
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        UIText.text = "Score: " + gameManager.score + "\nTimer: " + Mathf.RoundToInt(time.timeElapsed);
    }
}
