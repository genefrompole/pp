using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamescene : MonoBehaviour
{
    public void GoGameScene()
    {
        SceneManager.LoadScene("game-1");
    }

}