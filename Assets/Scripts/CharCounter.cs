using TMPro;
using UnityEngine;

public class CharacterCounter : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text counterText;
    public int maxChars = 200;

    void Start()
    {
        UpdateCounter(inputField.text);
        inputField.onValueChanged.AddListener(UpdateCounter);
    }

    void UpdateCounter(string text)
    {
        int currentLength = text.Length;
        counterText.text = $"{currentLength}/{maxChars}";
    }
}
