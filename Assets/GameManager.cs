using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        if (instance != this)
            Destroy(instance);
    }
    public void ResetScore(){
        score = 0;
    }
    public void AddScore(int value){
        score += value;
    }
}
