using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz Question", fileName ="New Question")]
public class QuestionScriptObject : ScriptableObject
{
  static int NumberOfAnswer =4;
  [TextArea(2,6)]
  [SerializeField] string question = "Enter a new question text!";
  [SerializeField] string [] answers = new string [NumberOfAnswer];

  [SerializeField] int correctAnswerIndex;
  public string GetQuestion()
  {
    return question;
  }
  public int GetCorrectAnswerIndex()
  {
    return correctAnswerIndex;
  }
  public string GetAnswer(int index) 
  {
    return answers[index];
  }
}
