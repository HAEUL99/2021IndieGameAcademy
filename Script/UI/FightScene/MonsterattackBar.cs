using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterattackBar : MonoBehaviour
{
    private Image[] attackbar;
    private ThreeDice threedice;

    public HPuiPlayer hpuiPlayer;
    private Animator monsteranim;

    private GameObject hit_Bombimg;

    void Start()
    {
        hpuiPlayer = GameObject.Find("CharacterHP").GetComponentInChildren<HPuiPlayer>();
        attackbar = GameObject.Find("MonsterAttackUI").GetComponentsInChildren<Image>();
        //bars = GameObject.Find("DiceBar").GetComponentsInChildren<Image>();
        threedice = GameObject.Find("DiceButton").GetComponentInChildren<ThreeDice>();

        monsteranim = GameObject.Find("monster").GetComponent<Animator>();
        hit_Bombimg = GameObject.Find("hit_Bomb");
        hit_Bombimg.SetActive(false);
    }

   

    public void SetattackBar()
    {

        /*
        if (threedice.totalcount == 5 && Isattacked == false)
        {
            
            // 2초있다가 없어지기
            Invoke("Resetattackbar", 2f);
            Invoke("Damage", 2.3f);
            
        }
        Isattacked = true;
        */

        // 2초있다가 없어지기
        Invoke("anim", 0.5f);
        Invoke("Resetattackbar", 2f);
        Invoke("Damage", 1.5f);

    }

    public void anim()
    {
        monsteranim.SetInteger("monsterstatus", 1);
        Invoke("Idleanim", 2f);
    }

    public void Resetattackbar()
    {
        for (int i = 0; i < 5; i++)
        {
            attackbar[i].color = Color.gray;

        }
        threedice.totalcount = 0;
    }

    public void Damage()
    {

        //hpuiPlayer.curHp -= 10;
        hit_Bombimg.SetActive(true);
        HPManager.hpmanager.playerhp -= 3;
        Invoke("deletemonstereffect", 2f);
        ShakeCamera.Instance.OnShakeCamera(0.15f, 0.9f);
        //monsteranim.SetInteger("monsterstatus", 1);
        //Invoke("Idleanim", 1f);
    }

   

    public void deletemonstereffect()
    {
        hit_Bombimg.SetActive(false);
    }


    private void Idleanim()
    {
        monsteranim.SetInteger("monsterstatus", 0);
    }


}
