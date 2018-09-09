using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Text m_completedGameBanner;
    public Text m_turnMarker;
    public Button m_backToMenu;
    public Button m_resetGameBoard;
    public Button[] m_gamePieces;

	// Use this for initialization
	void Start () {
        m_completedGameBanner.enabled = false;
        m_backToMenu.onClick.AddListener(BackToMenu);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void BackToMenu ()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
