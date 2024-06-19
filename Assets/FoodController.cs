using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
            Destroy(gameObject);
        if (other.gameObject.tag == "Enemy"){
            Debug.Log("Enemy Feed");
            Destroy(gameObject);
        }
    }
}
