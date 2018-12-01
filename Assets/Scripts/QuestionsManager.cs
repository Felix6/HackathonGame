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

    string name;
    int amountOfQuestions; 

    List<Question> Question = new List<Question>();
    List<Question> Answer = new List<Question>();

    bool isTrue;

    void Start()
    {
        isTrue = false;
    }

    void Update()
    {
        
    }

    public void CreateQuiz()
    {
        
        amountOfQuestions = int.Parse(quizLenght.text);
        string[] questions = new string[amountOfQuestions];
    }

    public void RemoveItem()
    {
        // myTextBoxList.Add(TextBox1);
        // myTextBoxList.Add(TextBox2);
        // mytextBoxList.Add(TextBox3);
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
