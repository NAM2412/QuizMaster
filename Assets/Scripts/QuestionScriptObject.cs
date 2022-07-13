using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz Question", fileName ="New Question")]
public class QuestionScriptObject : ScriptableObject
{
  [TextArea(2,6)]
  [SerializeField] string question = "Enter a new question text!";
}
