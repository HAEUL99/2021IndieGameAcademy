using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDiceUI : MonoBehaviour
{
    // 주사위 생성
    private GameObject dice;
    private GameObject diceposition;
    private GameObject parent;

    // 주사위 UI 생성
    //private GameObject diceui;

    // 주사위 클릭 버튼
    private Button diceButton;
    private DiceRoll diceroll;


    private void Start()
    {
        //diceui = GameObject.Find("DiceUI");
        diceButton = GameObject.Find("DiceButton").GetComponentInChildren<Button>();
        //diceui.SetActive(false);
        
    }
    public void ShowDiceSystem() 
    {
        //주사위 생성
        dice = Resources.Load<GameObject>("dice");
        GameObject obj = Instantiate(dice);

        diceposition = GameObject.Find("DicePosition");
        parent = GameObject.Find("Dice_and_Floor");
        obj.transform.position = diceposition.transform.position;
        obj.transform.parent = parent.transform;
        
        //주사위 ui 보이게하기
        //diceui.SetActive(true);
        //주사위의 DiceRoll 스크립트 OnRollButton을 DiceSpawnUI>DiceButton에 연결하기
        DiceRoll diceroll = obj.GetComponent(typeof(DiceRoll)) as DiceRoll;
        diceButton.onClick.AddListener(diceroll.OnRollButton);
    }
}