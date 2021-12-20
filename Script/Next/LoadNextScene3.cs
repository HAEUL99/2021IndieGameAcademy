using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene3 : MonoBehaviour
{
    public void Pressed_Fightbtn()
    {
        SceneManager.LoadScene("GameScene3");
    }
}
