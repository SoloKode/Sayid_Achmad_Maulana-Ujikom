using System.Collections;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    private PlayerController player;
    public float timeElapsed;
    void Start()
    {
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
