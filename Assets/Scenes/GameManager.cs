using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static ApplicationModel.Difficulty m_difficultyLevel = ApplicationModel.Difficulty.Easy;
    public static ApplicationModel.TurnState m_turnState;
    public static int[] m_gameBoard = new int[8];

    readonly int[,] m_verticalWins = new int[3, 3]
    {
        {0, 3, 6},
        {1, 4, 7},
        {2, 5, 8}
    };

    readonly int[,] m_horizontalWins = new int[3, 3]
    {
        {0, 1, 2},
        {3, 4, 5},
        {6, 7, 8}
    };

    readonly int[,] m_diagonalWins = new int[2, 3]
    {
        {0, 4, 8},
        {2, 4, 6}
    };

	// Use this for initialization
	void Start () {
        m_difficultyLevel = ApplicationModel.difficulty;
        m_turnState = ApplicationModel.DeterminePlayerStartState((int)ApplicationModel.playerStart)
            ? ApplicationModel.TurnState.PLAYER
            : ApplicationModel.TurnState.AI;
    }

    public static void ReversePlayerSide()
    {
        m_turnState = m_turnState == ApplicationModel.TurnState.AI
            ? ApplicationModel.TurnState.PLAYER
            : ApplicationModel.TurnState.AI;
    }

    public static void ResetGameBoard()
    {
        m_gameBoard = new int[8];
    }
}
