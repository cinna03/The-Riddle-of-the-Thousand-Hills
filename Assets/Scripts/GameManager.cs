using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI References")]
    public Text clueText;
    public Text letterText;
    public Text progressText;
    public GameObject congratsPanel;
    public Text congratsText;
    public GameObject losePanel;

    [Header("Game Objects")]
    public GameObject exitDoor;

    private string[] clues =
    {
        "Only the true ruler holds the key. Select the king.",
        "Place the king painting on the table to claim his throne.",
        "Flip the painting backward to reveal hidden truth.",
        "Switch the lights so the hidden message appears.",
        "Flip the painting upside down to make the message upright."
    };

    private string[] congratsMessages =
    {
        "Correct. The ruler stands acknowledged.",
        "The king claims his throne.",
        "The hidden truth is revealed.",
        "Light exposes what was unseen.",
        "Truth is upright. The door unlocks!"
    };

    private string[] letters = { "N", "Z", "I", "Z", "A" };

    private int currentLayer = 0;
    private string builtWord = "";

    public int CurrentLayer => currentLayer; // Safe public access

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if (congratsPanel != null)
            congratsPanel.SetActive(false);

        if (losePanel != null)
            losePanel.SetActive(false);

        builtWord = "";
        UpdateLetters();
        UpdateProgress();
        ShowClue();
    }

    public void CompleteLayer(int layerIndex)
    {
        if (layerIndex != currentLayer)
            return;

        // Add letter
        builtWord += letters[layerIndex];
        UpdateLetters();

        // Show congratulations
        if (congratsPanel != null)
        {
            congratsPanel.SetActive(true);
            congratsText.text = congratsMessages[layerIndex];
        }

        // Move to next layer
        currentLayer++;
        UpdateProgress();

        // Hide clue while congrats is showing
        if (clueText != null)
            clueText.gameObject.SetActive(false);

        Invoke(nameof(ProceedToNextStep), 3f);
    }

    void ProceedToNextStep()
    {
        if (congratsPanel != null)
            congratsPanel.SetActive(false);

        if (currentLayer >= 5)
        {
            UnlockDoor();
        }
        else
        {
            ShowClue();
        }
    }

    void ShowClue()
    {
        if (clueText != null && currentLayer < clues.Length)
        {
            clueText.gameObject.SetActive(true);
            clueText.text = clues[currentLayer];
        }
    }

    void UpdateProgress()
    {
        if (progressText != null)
            progressText.text = currentLayer + "/5 Layers";
    }

    void UpdateLetters()
    {
        if (letterText != null)
            letterText.text = builtWord;
    }

    void UnlockDoor()
    {
        if (exitDoor != null)
            exitDoor.SetActive(false);

        if (clueText != null)
            clueText.text = "The door is now open!";
    }

    public void LoseGame()
    {
        if (losePanel != null)
            losePanel.SetActive(true);

        Time.timeScale = 0f;
    }
}
