using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    public static HPManager hpmanager;
    public int playerhp;
    public bool onetime = false;

    private void Awake()
    {

        if (hpmanager != null)
        {
            Destroy(gameObject);
        }
        else
        {
            if (!onetime)
            {
                playerhp = 100;
                
            }
            onetime = true;
            hpmanager = this;

            //playerhp는 게임 시작시 딱 한번 초기화

            DontDestroyOnLoad(gameObject);

        }
        Debug.Log($"캐릭터의 전체 hp: {hpmanager.playerhp}");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
