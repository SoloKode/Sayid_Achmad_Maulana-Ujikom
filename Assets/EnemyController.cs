using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int speed = 10;
    public int hunger = 25;
    public int score = 1;
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
            Destroy(gameObject);
    }
}
