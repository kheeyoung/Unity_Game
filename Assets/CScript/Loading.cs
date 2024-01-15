using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Text loadTxt1;
    public Text loadTxt2;
    public Text loadTxt3;
    public Text loadTxt4;
    
    void Start()
    {
        loadTxt1.text="";
        loadTxt2.text="";
        loadTxt3.text="";
        loadTxt4.text="";
    }

    // Update is called once per frame
    void Update()
    {//미니겜1일 경우
        if(variable.var.loadcode==1){
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(4);
            }

        loadTxt1.text="RUN and RUN!";
        loadTxt2.text="장애물들을 피해 도시를 달려보세요.제한 시간은 45초! 당신은 과연 무사히 끝에 도착할 수 있습니까? *tip: 햄버거를 먹어보자!"; 
        loadTxt3.text="w=앞으로 이동 s=뒤로 이동 a=좌로 이동 d=우로 이동 space=점프";
        loadTxt4.text="click to start!";
        }
//미니겜2일 경우
        if(variable.var.loadcode==2){
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(5);
            }

        loadTxt1.text="좀비를 이겨라!";
        loadTxt2.text="좀비와 함께하는 기억력 테스트! 당신은 과연 전부 기억 할 수 있습니까?"; 
        loadTxt3.text="좀비가 말하는 키워드를 기억하고 동일한 순서로 키보드를 누르세요";
        loadTxt4.text="click to start!";
        }
//미니겜3일 경우
        if(variable.var.loadcode==3){
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(6);
            }

        loadTxt1.text="bouncing ball";
        loadTxt2.text="막대를 이용해서 모든 블럭을 깨트리세요! 기회는 단 3번."; 
        loadTxt3.text="w=좌측으로 이동 d=우측로 이동";
        loadTxt4.text="click to start!";
        }
//게임 오버시
        if(variable.var.loadcode==4){
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(2);
            }

        loadTxt1.text="Game over";
        loadTxt2.text=""; 
        loadTxt3.text="";
        loadTxt4.text="click to main";
        }
        //게임클리어시
        if(variable.var.loadcode==5){
            if (Input.GetMouseButtonDown(0))
            {
                variable.var.Gold+=100;
                SceneManager.LoadScene(2);
            }
            
        loadTxt1.text="Game Clear!";
        loadTxt2.text=""; 
        loadTxt3.text="+100 Gold";
        loadTxt4.text="click to main";
        }
    }
}
