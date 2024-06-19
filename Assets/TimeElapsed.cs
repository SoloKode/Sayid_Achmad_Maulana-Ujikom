using System.Collections;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    public static TimeElapsed instance;
    private PlayerController player;
    public float timeElapsed;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        if (instance != this)
            Destroy(instance);
    }
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
