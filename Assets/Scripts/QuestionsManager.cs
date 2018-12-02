using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class QuestionsManager : MonoBehaviour
{
    public InputField quizName;
    public InputField quizLenght;

    public InputField quizQuestion;
    public InputField quizCorrectAnswer;
    public InputField quizWrongAnswer1, quizWrongAnswer2, quizWrongAnswer3;

    public Button add;
    public Button finish;

    string _name;
    int amountOfQuestions;
    int index = 0;

    string question;
    string correctAnswer;
    string wrongAnswer1, wrongAnswer2, wrongAnswer3;

    string[] questions;
    string[] correctAnswers;

    void Start()
    {
        add.interactable = true;
        finish.interactable = false;
    }

    void Update()
    {
        
    }

    public void CreateQuiz()
    {
        _name = quizName.text;
        amountOfQuestions = int.Parse(quizLenght.text);

        Debug.Log("name = " + _name + " amount = " + amountOfQuestions);

        questions = new string[amountOfQuestions];

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RemoveItem()
    {
       // ahhhh
    }

    public void AddQuestion()
    {
        if(index < amountOfQuestions)
        {
            Debug.Log("Ahhhhhhhhhhhhh");
            
            question = quizQuestion.text;
            correctAnswer = quizCorrectAnswer.text;

            wrongAnswer1 = quizWrongAnswer1.text;
            wrongAnswer2 = quizWrongAnswer2.text;
            wrongAnswer3 = quizWrongAnswer3.text;

            questions[index] = question;
            correctAnswers[index] = correctAnswer;
            index++;

            quizQuestion.text = "";
            quizCorrectAnswer.text = "";
            quizWrongAnswer1.text = "";
            quizWrongAnswer2.text = "";
            quizWrongAnswer3.text = "";

            Debug.Log("question: " + questions[index] + "\n correct answer: " + correctAnswer);
        }

        if (index == amountOfQuestions)
        {
            //add.interactable = false;
            Debug.Log(index + "" + amountOfQuestions);
        }

    }


















    //----------------Question----------------------------------------------
    // public Question[] questions;
    // private static List<Question> unansweredQuestion;
    // private Question currentQuestion;

    // [SerializeField] private Text factText;
    // //----------------------------------------------------------------------

    // // Use this for initialization
    // void Start () {
    //     if(unansweredQuestion == null || unansweredQuestion.Count == 0) {
    //         unansweredQuestion = questions.ToList<Question>();
    //     }
	// 	GetRandomizeQuestion();
    //     Debug.Log(currentQuestion.fact + "is" + currentQuestion.isTrue);    
	// }
	
	// // Update is called once per frame
	// void Update () {
		
	// }
    
    // void GetRandomizeQuestion() {
    //     int randomizeQuestionIndex = UnityEngine.Random.Range(0, unansweredQuestion.Count);
    //     currentQuestion = unansweredQuestion[randomizeQuestionIndex];

    //     factText.text = currentQuestion.fact;

    //     unansweredQuestion.RemoveAt(randomizeQuestionIndex);
    // }

}
