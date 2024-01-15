using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public Text LiveTxt;
    public int life;

    void Start()
    {//생명 UI에 표시
        LiveTxt.text="♥= 3";
        life=3;
    }

    public void OnCollisionEnter(Collision collision) 
    {//공과 닿으면 감소
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            life=life-1;
            LiveTxt.text="♥= "+life;
        }
    }
    void Update()
    {//0이 되면 게임 오버
        if(life==0){
            variable.var.loadcode=4;
            SceneManager.LoadScene(3);
        }
    }
}
