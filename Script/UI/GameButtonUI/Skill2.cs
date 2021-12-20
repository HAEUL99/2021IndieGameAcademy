using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill2 : MonoBehaviour
{
    public HPuiEnemy hpuiEnemy;
    private Animator playeranim;
    private GameObject hit_forMonsterIMG;

    public void Start()
    {
        playeranim = GameObject.Find("character").GetComponent<Animator>();
        hit_forMonsterIMG = GameObject.Find("hit_forMonster (1)");
        hit_forMonsterIMG.SetActive(false);
    }

    public void clickedSkill()
    {


        playeranim.SetInteger("status", 2);
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
        hpuiEnemy.curHp -= 20;
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
