using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public enum GameState
    {
        MENU,
        GAME,
        PAUSE,
        ENDGAME
    }

    public List<GameState> StateList = new List<GameState>(2);

    public GameState gameState { get; private set; }

    public int vidas;

    public int pontos;

    public delegate void ChangeStateDelegate();

    public static ChangeStateDelegate changeStateDelegate;

    private static GameManager _instance;

    private GameManager()
    {
        vidas = 3;

        pontos = 0;

        gameState = GameState.MENU;

        StateList.Add(GameState.MENU);
        StateList.Add(GameState.MENU);
    }

    public static GameManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameManager();
        }

        return _instance;
    }

    public void changeState(GameState nextSate)
    {
        StateList[0] = gameState;
        StateList[1] = nextSate;

        if (
            nextSate == GameManager.GameState.GAME &&
            StateList[0] != GameManager.GameState.PAUSE
        ) Reset();

        gameState = nextSate;

        changeStateDelegate();
    }

    private void Reset()
    {
        vidas = 3;
        pontos = 0;
    }
}
