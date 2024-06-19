using System.Collections;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    public static TimeElapsed instance;
    private PlayerController player;
    public float timeElapsed;
    public AudioClip gameFinished;
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
        Camera.main.GetComponent<Animator>().SetBool("isGameFinish", true);
        Camera.main.GetComponent<AudioSource>().Stop();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(gameFinished);
        player.transform.position = new Vector3(0, 0, -9.7f);
    }
}
