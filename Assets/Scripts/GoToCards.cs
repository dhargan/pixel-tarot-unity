using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoToCardsScene : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text errorText;

    public void LoadCardsScene()
    {
        string input = inputField.text.Trim();

        if (string.IsNullOrEmpty(input))
        {            
            if (errorText != null)
                errorText.text = "Enter your question first!";
            return;
        }

        GameData.userInputText = input;
        SceneManager.LoadScene("Cards");
    }
}
