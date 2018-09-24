using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Text m_completedGameBanner;
    public Text m_turnMarker;
    public Button m_backToMenu;
    public Button m_resetGameBoard;
    public Button[] m_gamePieces;
    public bool m_playerStart;
    public static string m_turnDisplay = "x";

	// Use this for initialization
	void Start () {
        m_completedGameBanner.enabled = false;
        m_backToMenu.onClick.AddListener(BackToMenu);
        m_playerStart = ApplicationModel.DeterminePlayerStartState(ApplicationModel.playerStart);

        var idx = 0;
        foreach (Button m_button in m_gamePieces)
        {
            m_button.onClick.AddListener(delegate
            {
                PlayerMove(idx, m_button.GetComponentInChildren<Text>().text);
            });
            idx++;
        }
	}

    private bool CheckGameState()
    {
        return false;
    }

    void PlayerMove (int index, string value)
    {
        if (GameManager.m_turnState == ApplicationModel.TurnState.PLAYER)
        {

        }
    }

    void AiMove()
    {
        GameManager.ReversePlayerSide();
    }
	
	// Update is called once per frame
	void Update () {

        if (GameManager.m_turnState == ApplicationModel.TurnState.AI)
        {

        }
	}

    void BackToMenu ()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
