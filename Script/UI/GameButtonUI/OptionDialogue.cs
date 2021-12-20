using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OptionDialogue : MonoBehaviour
{
    private string optionDialouge = " ";
    private TMP_Text dialogueText;

    public void ShowDialogue() 
    {
        
        dialogueText = GameObject.Find("OptionDialogue").GetComponent<TMP_Text>();
        StartCoroutine(TypeSentence(optionDialouge));
    }
    IEnumerator TypeSentence(string sentences)
    {

        foreach (char letter in sentences.ToCharArray())
        {
            //StartCoroutine(WaitFunc());
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

    }

}
