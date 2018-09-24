using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartupController : MonoBehaviour
{
    public Slider m_slider;
    public Button m_startButton, m_sideSelectX, m_sideSelectO;
    public Text m_difficultyLabel;

    private bool m_sideSet = false;
    private string m_sideSelected = "X";

    // Use this for initialization
    void Start()
    {
        m_difficultyLabel.text = ApplicationModel.GetDifficultyLabel(Mathf.FloorToInt(m_slider.value));
        m_slider.onValueChanged.AddListener(delegate {
            SetDifficultyLevel(Mathf.FloorToInt(m_slider.value));
        });

        m_sideSelectX.interactable = false;
        m_sideSet = true;
        ApplicationModel.playerStart = (int) ApplicationModel.PlayerStartState.Unset;

        m_sideSelectX.onClick.AddListener(delegate {
            SetPlayerSide(m_sideSelectX.GetComponentInChildren<Text>().text);
        });
        m_sideSelectO.onClick.AddListener(delegate {
            SetPlayerSide(m_sideSelectO.GetComponentInChildren<Text>().text);
        });

        m_startButton.onClick.AddListener(LoadGameBoard);
    }

    void SetPlayerSide(string side)
    {
        if (side == "X")
        {
            m_sideSelectO.interactable = true;
            m_sideSelectX.interactable = false;
            ApplicationModel.playerStart = (int) ApplicationModel.PlayerStartState.Start;
        }
        else
        {
            m_sideSelectX.interactable = true;
            m_sideSelectO.interactable = false;
            ApplicationModel.playerStart = (int) ApplicationModel.PlayerStartState.Last;
        }
    }

    void SetDifficultyLevel (int level)
    {
        m_difficultyLabel.text = ApplicationModel.GetDifficultyLabel(level);
        ApplicationModel.difficulty = (ApplicationModel.Difficulty)level;
    }

    void LoadGameBoard()
    {
        ApplicationModel.gameStarted = true;
        SceneManager.LoadScene("GameBoard");
    }


}
