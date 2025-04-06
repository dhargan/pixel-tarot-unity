using UnityEngine;

public class StartReading : MonoBehaviour
{
    // Method to load the QuestionScreen
    public void LoadQuestionScreen()
    {        
        UnityEngine.SceneManagement.SceneManager.LoadScene("QuestionScene");
    }
}
