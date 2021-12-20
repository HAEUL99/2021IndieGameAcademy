using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skillbtn : MonoBehaviour
{
    private ThreeDice threedice;
    private Button[] skillBtn;
    private int dicebarnum;
    private Image[] image;
    
    private void Start()
    {
        threedice = GameObject.Find("DiceButton").GetComponent<ThreeDice>();
        skillBtn = gameObject.GetComponentsInChildren<Button>();
        image = gameObject.GetComponentsInChildren<Image>();
        //Debug.Log($"skillBtn: {skillBtn.LengthImage
        for (int i = 0; i < skillBtn.Length; i++) 
        {
            skillBtn[i].enabled = false;
            image[i].color = Color.black;
        }
    }

    public void EnablesSkillcard()
    {
        Debug.Log("enableskillcard");
        //dicebarnum = threedice.total;
        if (DiceRoll.result >= 1 && DiceRoll.result <6)
        {
            Debug.Log($"total: {DiceRoll.result}");
            skillBtn[0].enabled = true;
            image[0].color = Color.white;

        }
        else if (DiceRoll.result >= 6 && DiceRoll.result < 9)
        {
            Debug.Log($"dicebarnum: {DiceRoll.result}");
            skillBtn[0].enabled = true;
            skillBtn[1].enabled = true;
            image[0].color = Color.white;
            image[1].color = Color.white;
        }
        else if (DiceRoll.result >= 9 && DiceRoll.result < 11)
        {
            Debug.Log($"dicebarnum: {DiceRoll.result}");
            skillBtn[0].enabled = true;
            skillBtn[1].enabled = true;
            skillBtn[2].enabled = true;
            image[0].color = Color.white;
            image[1].color = Color.white;
            image[2].color = Color.white;
        }
        else if (DiceRoll.result >= 11)
        {
            skillBtn[0].enabled = false;
            skillBtn[1].enabled = false;
            skillBtn[2].enabled = false;
            image[0].color = Color.black;
            image[1].color = Color.black;
            image[2].color = Color.black;
            Debug.Log($"dicebarnum: {DiceRoll.result}");
            

        }

        

    }


}
