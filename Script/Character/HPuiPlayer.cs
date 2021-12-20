using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPuiPlayer : MonoBehaviour
{
 
    private Slider hpbar;

    public float maxHp = 100;
    //public float curHp;



    // Start is called before the first frame update
    void Start()
    {
        hpbar = gameObject.GetComponent<Slider>();
        //curHp = HPManager.hpmanager.playerhp;
        hpbar.value = (float)HPManager.hpmanager.playerhp / (float)maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
        HandleHp();
    }

    private void HandleHp()
    {
        hpbar.value = Mathf.Lerp(hpbar.value, (float)HPManager.hpmanager.playerhp / (float)maxHp, Time.deltaTime * 10);
    }
}
