using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int speed = 10;
    public int hunger = 25;
    public int score = 1;
    private AudioSource[] audioSources;
    private bool scored = false;
    private void Start() {
        audioSources = GetComponents<AudioSource>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
    public void Feed(int value)
    {
        hunger -= value;
        if (hunger <= 0)
        {
            if (!scored)
            {
                GameManager.instance.AddScore(score);
                foreach (var audio in audioSources)
                {
                    audio.Play();
                }
                scored = true;
            }
            Destroy(gameObject, 0.25f);
        }
    }
}
