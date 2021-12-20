using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fightscene7 : MonoBehaviour
{
    public HPuiEnemy hpuienemy;
    public HPuiPlayer hpuiplayer;

    private void Start()
    {
        //hpuienemy = GameObject.Find("EnemyHP").GetComponent<HPuiEnemy>();
    }
    // Update is called once per frame
    void Update()
    {
        if (hpuienemy.curHp <= 0)
        {
            SceneManager.LoadScene("GameScene21");
        }

        if (HPManager.hpmanager.playerhp <= 0)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
