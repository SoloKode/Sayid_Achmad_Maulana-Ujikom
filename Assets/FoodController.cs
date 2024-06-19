using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    int hungervalue = 25;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
            Destroy(gameObject);
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyController>().Feed(hungervalue);
            Destroy(gameObject);
        }
    }
}
