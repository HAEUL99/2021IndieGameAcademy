using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill3 : MonoBehaviour
{
    public HPuiEnemy hpuiEnemy;
    private Animator playeranim;
    private GameObject hit_forMonsterIMG;

    public void Start()
    {
        playeranim = GameObject.Find("character").GetComponent<Animator>();
        hit_forMonsterIMG = GameObject.Find("hit_forMonster (2)");
        hit_forMonsterIMG.SetActive(false);
    }

    public void clickedSkill()
    {


        playeranim.SetInteger("status", 3);
        //hpuiEnemy.curHp -= 10;
        //Invoke("animskill1", 1f);
        Invoke("damagemonster", 2f);
        //hpuiEnemy.curHp -= 10;


        Invoke("Idleanim", 1f);

        //playeranim.SetInteger("status", 0);
    }
    public void damagemonster()
    {
        hit_forMonsterIMG.SetActive(true);
        hpuiEnemy.curHp -= 30;
        Invoke("deletemonstereffect", 1f);
    }

    public void deletemonstereffect()
    {
        hit_forMonsterIMG.SetActive(false);
    }
    public void Idleanim()
    {
        playeranim.SetInteger("status", 0);
    }

}
