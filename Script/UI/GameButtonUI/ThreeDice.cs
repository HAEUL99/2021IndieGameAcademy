using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeDice : MonoBehaviour
{
    private DiceRoll dice;
    private GameObject obj;
    private Transform[] diceobjects;
    private GameObject diceposition;
    public static int count = 0;
    public int total = 0;
    private GameObject parent;

    //button_enableand_reset에서 clickedskillbtn 변수값 받아와서
    //true이면 주사위 던질 수 있게 해주기
    private Button_Enableand_Reset button_enabledand_reset;
    public bool Isclidkedskill;

    //카드를 enable 시킬건지에 대한 변수
    private Skillbtn skillbtn;

    //barui
    private DiceBar dicebar;

    //스킬카드누른횟수
    public static int fightcount;
    //주사위굴린횟수
    public int totalcount;

    //적의 공격
    private MonsterattackBar monsterattackBar;
    private Image[] attackbar;

    //플레이어 hp
    private MonsterattackBar monsterattckBar;

    private void Start()
    {

        fightcount = 0;
        totalcount = 0;
        button_enabledand_reset = GameObject.Find("SkillBtn").GetComponent<Button_Enableand_Reset>();
        skillbtn = GameObject.Find("SkillBtn").GetComponent<Skillbtn>();
        dicebar = GameObject.Find("DiceBar").GetComponent<DiceBar>();
        monsterattackBar = GameObject.Find("MonsterAttackUI").GetComponent<MonsterattackBar>();
        monsterattckBar = GameObject.Find("MonsterAttackUI").GetComponent<MonsterattackBar>();

    }

    public void DiceButtonclicked()
    {
        if (count == 3)
        {
            return;
        }
        obj = Resources.Load<GameObject>("dice");
        GameObject obj1 = Instantiate(obj);
        diceposition = GameObject.Find("DicePosition");
        parent = GameObject.Find("Dice_and_Floor");
        obj1.transform.position = diceposition.transform.position;
        obj1.transform.parent = parent.transform;

        dice = obj1.GetComponent<DiceRoll>();
        //dice[count].OnRollButton();
        //주사위 굴리는 함수
        dice.Invoke("OnRollButton", 0.1f);
        //주사위값 받아오는 함수
        Invoke("DiceResult", 2f);
        //스킬버튼 활성화 함수
        skillbtn.Invoke("EnablesSkillcard", 1f);
        //주사위눈금 활성화 함
        dicebar.Invoke("SetBar", 1f);
        count++;
        totalcount++;
        Debug.Log($"totalcount: {totalcount}");
        attackbar = GameObject.Find("MonsterAttackUI").GetComponentsInChildren<Image>();
        for (int i = 1; i < totalcount+1; i++)
        {
            if (i == 1 || i == 2)
            {
                attackbar[i-1].color = Color.green;
            }
            if (i == 3 || i == 4)
            {
                attackbar[i-1].color = Color.yellow;
            }
            if (i == 5)
            {
                attackbar[i-1].color = Color.red;
            }

        }
        if (totalcount == 5)
        {
            monsterattackBar.Invoke("SetattackBar", 2f);
            totalcount = 0;
        }

        
        


    }

    private void Update()
    {
        Isclidkedskill = button_enabledand_reset.clickedskillbtn;
        if (Isclidkedskill || dicebar.IsOvernum)
        {
            button_enabledand_reset.clickedskillbtn = false;
            
            fightcount++;
            Reset();
            if (dicebar.IsOvernum)
            {
                dicebar.IsOvernum = false;
                //monsterattckBar.Damage();
                monsterattckBar.Invoke("Damage", 2f);
                monsterattckBar.Invoke("anim", 0.2f);
                //Debug.Log("monsterdamage");
            }
            
        }
    }

    public void DiceResult() 
    {
        total = DiceRoll.result;
        Debug.Log($"턴마다 결과 DiceRoll.result: {DiceRoll.result}");
        Debug.Log($"턴마다 결과 total: {total}");

    }


    public void Reset()
    {
        /*
        Debug.Log("리셋해야됨");
        //count = 0;
        for (int i = 0; i < count; i++)
        {
            dice[i].StartCoroutine(dice[i].diceRollCo());
        }
        */
        dicebar.Invoke("ResetBar", 0.5f);
        diceobjects = GameObject.Find("Dice_and_Floor").GetComponentsInChildren<Transform>();
      
        for (int i = 1; i < diceobjects.Length; i++)
        {
   
            Destroy(diceobjects[i].gameObject, .3f);
        }
        
        count = 0;
        DiceRoll.result = 0;
        Debug.Log($"전투몇: {fightcount}");

    }



}
