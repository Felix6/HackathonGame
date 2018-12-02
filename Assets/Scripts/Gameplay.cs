using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
	public Text gameQuestion;
	public Button gameCorrectAnswer;
	public Button gameWrong1, gameWrong2, gameWrong3;

	// Use this for initialization
	void Start ()
	{
		gameQuestion.text = QuestionsManager.question;
		gameCorrectAnswer.GetComponentInChildren<Text>().text = QuestionsManager.correctAnswer;
		gameWrong1.GetComponentInChildren<Text>().text = QuestionsManager.wrongAnswer1;
		gameWrong2.GetComponentInChildren<Text>().text = QuestionsManager.wrongAnswer2;
		gameWrong3.GetComponentInChildren<Text>().text = QuestionsManager.wrongAnswer3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CorectAnswerChoice()
	{
		
	}
}
