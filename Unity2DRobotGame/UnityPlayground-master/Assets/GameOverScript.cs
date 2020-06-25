using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
    /*private bool gameOver = false;
    public void GameOver(int playerNumber)
    {
        // only set game over UI if game is not over
        if (!gameOver)
        {
            gameOver = true;
            statsPanel.SetActive(false);
            gameOverPanel.SetActive(true);
        }
    }
    public void SetHealth(int amount, int playerNumber)
    {
        playersHealth[playerNumber] = amount;
        numberLabels[playerNumber].text = playersHealth[playerNumber].ToString();
    }



    public void ChangeHealth(int change, int playerNumber)
    {
        SetHealth(playersHealth[playerNumber] + change, playerNumber);

        if (gameType != GameType.Endless
            && playersHealth[playerNumber] <= 0)
        {
            GameOver(playerNumber);
        }

    }
    
}*/
