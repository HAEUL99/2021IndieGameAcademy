using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFight : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("FightScene_MS");
    }
}
