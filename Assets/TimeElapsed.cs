using System.Collections;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    public static TimeElapsed instance;
    private PlayerController player;
    public float timeElapsed;
    void Start()
    {
        if (instance == null)
            instance = this;
        StartCoroutine(TimeElapsing());
        player = PlayerController.instance;

    }
    private IEnumerator TimeElapsing()
    {
        timeElapsed = 0;
        while (timeElapsed < 60)
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        player.isGameFinish = true;
    }
}
