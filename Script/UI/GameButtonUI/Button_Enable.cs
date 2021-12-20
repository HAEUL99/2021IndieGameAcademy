using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button_Enable : MonoBehaviour
{
    private Button[] buttons;

    private void Start()
    {
        buttons = gameObject.GetComponentsInChildren<Button>();
    }


    public void DisableButton()
    {
        for(int i = 0; i< buttons.Length; i++) 
        {
            buttons[i].enabled = false;
        }
   
    }
}

