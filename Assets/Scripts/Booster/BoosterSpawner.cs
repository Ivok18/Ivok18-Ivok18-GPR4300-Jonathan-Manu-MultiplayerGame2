using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterSpawner : MonoBehaviour
{
    [SerializeField] private Transform prefab;
    public float timeBetweenSpawns;
    public float timeUntilNextSpawn;
    public float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextSpawn = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {

        UpdateTimer();
    }

    public void UpdateTimer()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().nbOfPlayersLeft > 1)
        {
            if (timeUntilNextSpawn >= 0)
            {
                timeUntilNextSpawn -= Time.deltaTime;
            }

            else
            {
                Transform booster = Instantiate(prefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
                timeUntilNextSpawn = timeBetweenSpawns;
            }

        }
    }
}
