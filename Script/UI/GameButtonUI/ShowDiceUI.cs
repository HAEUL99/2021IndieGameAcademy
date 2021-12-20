using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDiceUI : MonoBehaviour
{
    // �ֻ��� ����
    private GameObject dice;
    private GameObject diceposition;
    private GameObject parent;

    // �ֻ��� UI ����
    //private GameObject diceui;

    // �ֻ��� Ŭ�� ��ư
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
        //�ֻ��� ����
        dice = Resources.Load<GameObject>("dice");
        GameObject obj = Instantiate(dice);

        diceposition = GameObject.Find("DicePosition");
        parent = GameObject.Find("Dice_and_Floor");
        obj.transform.position = diceposition.transform.position;
        obj.transform.parent = parent.transform;
        
        //�ֻ��� ui ���̰��ϱ�
        //diceui.SetActive(true);
        //�ֻ����� DiceRoll ��ũ��Ʈ OnRollButton�� DiceSpawnUI>DiceButton�� �����ϱ�
        DiceRoll diceroll = obj.GetComponent(typeof(DiceRoll)) as DiceRoll;
        diceButton.onClick.AddListener(diceroll.OnRollButton);
    }
}