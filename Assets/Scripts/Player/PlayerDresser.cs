using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDresser : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

        ApplyDress();
    }

    public void ApplyDress()
    {
        spriteRenderer = transform.Find("Sprite").GetComponent<SpriteRenderer>();
        while (GameObject.Find("DressManager").GetComponent<DressManager>().CheckColor(new Color(Random.Range(0, 100) / 100f, Random.Range(0, 100) / 100f, Random.Range(0, 100) / 100f)))
        {
            spriteRenderer.color = new Color(Random.Range(0, 100) / 100f, Random.Range(0, 100) / 100f, Random.Range(0, 100) / 100f);
        }
        spriteRenderer.color = new Color(Random.Range(0, 100) / 100f, Random.Range(0, 100) / 100f, Random.Range(0, 100) / 100f);
        GameObject.Find("DressManager").GetComponent<DressManager>().forbiddenColors.Add(spriteRenderer.color);
    }

  
}
