using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFightScene1 : MonoBehaviour
{
    public void Pressed_Fightbtn()
    {
        SceneManager.LoadScene("GameScene2");
    }
}
