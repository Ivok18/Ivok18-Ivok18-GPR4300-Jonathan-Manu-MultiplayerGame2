using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float maxHealth;
    private float currentHealth;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = transform.Find("Sprite").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().nbOfPlayersLeft > 1)
        {
            GetDamage(8f * Time.deltaTime);
        }
            
    }


    public void GetDamage(float damage)
    {
        currentHealth -= damage;
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, currentHealth / maxHealth);
        if (currentHealth <= 0 )
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().CheckWin();
            Destroy(gameObject);    
        }    
    }


    public void Heal(float heal)
    {
        currentHealth += heal;
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, currentHealth / maxHealth);
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
       
        }
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }


}
