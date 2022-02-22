using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Pause : MonoBehaviour
{
    GameManager gm;

    // Start is called before the first frame update
    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    public void Retornar()
    {
        gm.changeState(GameManager.GameState.GAME);
    }

    public void Inicio()
    {
        gm.changeState(GameManager.GameState.MENU);
    }
}
