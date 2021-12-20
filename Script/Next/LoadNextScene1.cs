using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene1 : MonoBehaviour
{
    public void Pressed_Fightbtn()
    {
        SceneManager.LoadScene("GameScene1");
    }
}
