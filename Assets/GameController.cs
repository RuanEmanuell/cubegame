using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    bool gameEnd=false;
    public float restartDelay=1f;

    public void GameOver(){
        if(gameEnd==false){
            Debug.Log("Game Over");
            gameEnd=true;
            Invoke("Restart", 1f);
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameEnd=false;
    }

}
