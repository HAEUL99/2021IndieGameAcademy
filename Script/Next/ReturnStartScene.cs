using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnStartScene : MonoBehaviour
{
    public void Pressed_Fightbtn()
    {
        SceneManager.LoadScene("StartScene");
    }
}
