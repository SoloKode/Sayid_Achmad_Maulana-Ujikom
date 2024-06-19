using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text UIText;
    public Text UIScoreFinish;
    private TimeElapsed time;
    public GameObject gameFinishedUI;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        time = TimeElapsed.instance;
        gameManager = GameManager.instance;
        gameFinishedUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.instance.isGameFinish)
        {
            StartCoroutine(EnableFinishUI());
            UIText.enabled = false;
        }
        else
        {
            UIText.text = "Score: " + gameManager.score + "\nTimer: " + Mathf.Abs(60 - Mathf.RoundToInt(time.timeElapsed));
        }
    }
    public void LoadSceneGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void LoadSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    IEnumerator EnableFinishUI()
    {
        yield return new WaitForSeconds(2);
        if (!gameFinishedUI.activeSelf)
            gameFinishedUI.SetActive(true);
        UIScoreFinish.text = "Score: " + gameManager.score;
    }
}
