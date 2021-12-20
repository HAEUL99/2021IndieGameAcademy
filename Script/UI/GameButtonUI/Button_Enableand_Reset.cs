using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Enableand_Reset : MonoBehaviour
{
    private Button[] buttons;
    private Image[] images;
    //버튼 드래그드랍 필요x
    public bool clickedskillbtn = false;

    private ThreeDice threedice;
    //private bool Isfirstattack;

    private void Start()
    {
        buttons = gameObject.GetComponentsInChildren<Button>();
        images = gameObject.GetComponentsInChildren<Image>();
        threedice = GameObject.Find("DiceButton").GetComponent<ThreeDice>();
    }


    public void DisableButton()
    {
        
        for (int i = 0; i < buttons.Length; i++)
        {
            //Debug.Log($"버튼개수 {i}");
            buttons[i].enabled = false;
            images[i].color = Color.black;

        }
        //Debug.Log("buttondisable");
        clickedskillbtn = true;


    }
}
