using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    private float healBoost = 75f;
    private float speedBoost = 50f;
  

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().Heal(healBoost);
            collision.gameObject.GetComponent<PlayerMovement>().IncreaseSpeed(speedBoost);
            Destroy(gameObject);
        }
    }
}
