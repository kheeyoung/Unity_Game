using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game2start : MonoBehaviour
{
    public float time;
    public Text text;
    public Text mytext;
    int num;
    int pase=0;
    int arrynum=0;

    string[] key = new string[4];
    int [] keyvar=new int[5];

    void Start()
    {//정답 배열에 난수로 담기
        key[0]="w";
        key[1]="a";
        key[2]="s";
        key[3]="d";

        keyvar[0]=Random.Range(0, 3);
        keyvar[1]=Random.Range(0, 3);
        keyvar[2]=Random.Range(0, 3);
        keyvar[3]=Random.Range(0, 3);
        keyvar[4]=Random.Range(0, 3);
        time=0;
        num=0;
        text.text="그럼 시작이다!";
        
        
    }

    void Update()
    {//일정 시간마다 좀비의 대사 바뀌기
        time+=Time.deltaTime;

        num=(int)time;
        switch (num)
        {
            case 1: {
                text.text=key[keyvar[0]];
                break;
            }
            case 2: {
                text.text="";
                break;
            }
            case 3: {
                text.text=key[keyvar[1]];
                break;
            }
            case 4: {
                text.text="";
                break;
            }
            case 5: {
                text.text=key[keyvar[2]];
                break;
            }
            case 6: {
                text.text="";
                break;
            }
            case 7: {
                text.text=key[keyvar[3]];
                break;
            }
            case 8: {
                text.text="";
                break;
            }
            case 9: {
                text.text=key[keyvar[4]];
                break;
            }
            case 10: {
                text.text="자, 그럼 정답은? (*키보드로 입력해주세요)";
                pase=1;
                break;
            }
        }
        //정답 입력, 확인후 클리어/게임 오버 판정
        if(pase==1){
            if(Input.GetKeyDown(KeyCode.A))
            {
                mytext.text="a";
                if(key[keyvar[arrynum]]=="a"){
                    text.text="정답이다!";
                    arrynum++;
                }
                else{
                    text.text="오답이다!";
                    variable.var.loadcode=4;
                    SceneManager.LoadScene(3);
                }
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                mytext.text="s";
                if(key[keyvar[arrynum]]=="s"){
                    text.text="정답이다!";
                    arrynum++;
                }
                else{
                    text.text="오답이다!";
                    variable.var.loadcode=4;
                    SceneManager.LoadScene(3);
                }
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                mytext.text="d";
                if(key[keyvar[arrynum]]=="d"){
                    text.text="정답이다!";
                    arrynum++;
                }
                else{
                    text.text="오답이다!";
                    variable.var.loadcode=4;
                    SceneManager.LoadScene(3);
                }
            }
            if(Input.GetKeyDown(KeyCode.W))
            {
                mytext.text="w";
                if(key[keyvar[arrynum]]=="w"){
                    text.text="정답이다!";
                    arrynum++;
                }
                else{
                    text.text="오답이다!";
                    variable.var.loadcode=4;
                    SceneManager.LoadScene(3);
                }
            }

            if(arrynum==5)
            {
                text.text="전부 정답이다! 네가 이겼다!";
                variable.var.loadcode=5;
                SceneManager.LoadScene(3);
            }
        }
    }
}
