using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float nbOfPlayersLeft;
   
    public void AddPlayerToParty()
    {
        nbOfPlayersLeft++;
    }

    public void CheckWin()
    {
        nbOfPlayersLeft--;
        if(nbOfPlayersLeft <= 1 && GameObject.Find("DressManager").GetComponent<DressManager>().forbiddenColors.Count > 1)
        {
            SceneManager.LoadScene("Winner Scene");
        }
    }
  
}
