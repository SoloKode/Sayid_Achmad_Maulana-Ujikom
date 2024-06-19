using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void LoadSceneGameplay(){
        SceneManager.LoadScene("Gameplay");
    }
    public void ExitGame(){
        Application.Quit();
    }

}
