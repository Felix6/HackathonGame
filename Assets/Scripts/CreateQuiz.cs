using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateQuiz : MonoBehaviour {

	public void BackToSelectScreen()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void CreateQuizz()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }
}
