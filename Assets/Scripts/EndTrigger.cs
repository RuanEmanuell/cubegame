using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameController gameController;

    void OnTriggerEnter(){
        gameController.FinishLevel();
    }

}
