using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI progressText;
    public TextMeshProUGUI lettersText;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateProgress(int current, int total)
    {
        progressText.text = current + "/" + total + " Layers";
    }

    public void AddLetter(string letter)
    {
        lettersText.text += letter + " ";
    }

    public void ShowWin()
    {
        Debug.Log("YOU WIN");
    }

    public void ShowLose()
    {
        Debug.Log("TIME UP");
    }
}
