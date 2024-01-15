using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroUITextControl : MonoBehaviour
{
    public Text IntroTxt;
    public int txt=0;
    void Start()
    {
        IntroTxt.text="안녕? 여기는 당신을 위한 공원이야.    (click to next)";
    }

    // Update is called once per frame
    void Update()
    {
        //클릭마다 변수(txt)값 상승
        if (Input.GetMouseButtonDown(0))
        {
            txt += 1;
        }
        //변수 값에 따른 스크립트 출력
        switch(txt){
            case 1 : IntroTxt.text="[어때? 평화로워 보이지?]"; 
            break; 

            case 2 : IntroTxt.text="[...]"; 
            break; 

            case 3 : IntroTxt.text="[아, 조금 휑하게 보인다고?]"; 
            break; 

            case 4 : IntroTxt.text="[음... 그러면 우리 같이 여기를 꾸며보자.]"; 
            break; 

            case 5 : IntroTxt.text="[걱정마, 분명 너라면 멋진 공원을 만들 수 있을거야.]";
            break; 

            case 6 : SceneManager.LoadScene(2);
            break;
        }
    }
}
