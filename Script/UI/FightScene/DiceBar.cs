using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DiceBar : MonoBehaviour
{
    private ThreeDice threedice;
    private Image[] bars;
    //private int dicebarnum;

    //16개이상 채워졌는지 확인
    public bool IsOvernum = false;

    //노란불 시간지연
   

    private void Start()
    {
        threedice = GameObject.Find("DiceButton").GetComponent<ThreeDice>();
        bars = GameObject.Find("DiceBar").GetComponentsInChildren<Image>();
    }

    public void SetBar()
    {
        //dicebarnum = threedice.total;
        if (DiceRoll.result < 11) // 나온 주사위가 10이하이면, 나온 수 만큼 검정색 
        {
            for (int i = 0; i < DiceRoll.result; i++)
            {
                if (DiceRoll.result >= 1 && DiceRoll.result < 6)
                {
                    bars[i].color = Color.white;
                }
                else if (DiceRoll.result >= 6 && DiceRoll.result < 9)
                {
                    bars[i].color = Color.blue;
                }
                else if (DiceRoll.result >= 9 && DiceRoll.result < 11)
                {
                    bars[i].color = Color.yellow;
                }



            }
        }
        else // 주사위가 11이상, 11개 다차고 다른색
        {
            IsOvernum = true;
            for (int i = 0; i < 10; i++)
            {
                bars[i].color = Color.red;
                
            }
        }
    }

    public void ResetBar()
    {
        for (int i = 0; i < 10; i++)
        {
            bars[i].color = Color.gray;
        }
    }
}
