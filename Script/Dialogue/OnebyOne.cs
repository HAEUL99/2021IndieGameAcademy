using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OnebyOne : MonoBehaviour
{
    //드래그드랍 O
    public Button[] buttons = { };
    public GameObject previousDialogue = null;
    

    //드래그드랍 X
    private TMP_Text dialogueText;
    private string dialogueTextSub;
   // public OnebyOne previousonebyone;
    public bool coroutineBool = false;
    private bool Onetime = false;
    private void Start()
    {
        dialogueText = gameObject.GetComponent<TMP_Text>();
        dialogueTextSub = dialogueText.text;
        dialogueText.text = "";
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
        if (previousDialogue == null)
        {          
            StartCoroutine(TypeSentence(dialogueTextSub));
        }
    }

    private void Update()
    {
        if (Onetime == false && previousDialogue != null && previousDialogue.GetComponent<OnebyOne>().coroutineBool == true)
        {
            StartCoroutine(TypeSentence(dialogueTextSub));
            Onetime = true;
        }
    }

    IEnumerator TypeSentence(string sentences)
    {
        coroutineBool = false;
        foreach (char letter in sentences.ToCharArray())
        {
            //StartCoroutine(WaitFunc());
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        coroutineBool = true;

        VisibleButtons();

    }

    IEnumerator WaitFunc() 
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(2f);
    }

    public void VisibleButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }


    }
}
