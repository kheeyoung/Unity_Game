using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveOtherScence : MonoBehaviour
{
    //버튼 클릭시 미니게임의 변수 받아서 로딩화면 이동
    public void game1()
    {
        variable.var.loadcode=1;
        SceneManager.LoadScene(3);
    }

    public void game2()
    {
        variable.var.loadcode=2;
        SceneManager.LoadScene(3);
    }

    public void game3()
    {
        variable.var.loadcode=3;
        SceneManager.LoadScene(3);
    }
}
