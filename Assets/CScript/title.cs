using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    public GameObject Data;

    //튜토리얼 씬으로 이동
    public void newGame()
    {
        SceneManager.LoadScene(1);
    }
    //바로 메인 씬으로 이동
    public void loadGame()
    {
        SceneManager.LoadScene(2);
    }

}
