using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopShow : MonoBehaviour
{
    private bool Shop;
    public GameObject ShopUI;
    public GameObject ship;
    public GameObject Bench;
    public GameObject DoubleBench;
    public GameObject Fountain1;
    public GameObject Fountain2;
    public GameObject Hovel;
    public Text GoldTxt;
    public int Gold=0;
    public Text ShopTxt;

    public int ShipValue;
    public int FountainValue;
    public int HovelValue;

    void Start(){
        //저장된 값(골드와 정원 상태) 불러오기
        Goldstate();
        Shop=true;
        if(variable.var.Benchcode==1)
        {ship.SetActive(true);
            DoubleBench.SetActive(true);
            Bench.SetActive(true);}
        if(variable.var.Fountaincode==1)
        {Fountain1.SetActive(true);
            Fountain2.SetActive(true);}
        if(variable.var.Hovelcode==1)
        {Hovel.SetActive(true);
            variable.var.Hovelcode=1; }
    }

    void Update()
    {
        //아이템 구매 현황 카운트
        if(variable.var.Hovelcode==1 && variable.var.Benchcode==1 && variable.var.Fountaincode==1){
            ShopTxt.text="모든 아이템 구매 완료! 축하드려요!";
        }
    }
    //로드 기능
    public void Load()
    {    
        //골드 값 업데이트
        variable.var.Gold=PlayerPrefs.GetInt("Gold");

        //구매한 오브젝트 보이기
        if(PlayerPrefs.GetInt("Ship")==1){
            ship.SetActive(true);
            DoubleBench.SetActive(true);
            Bench.SetActive(true);
            variable.var.Benchcode=1;
                
        }
        if(PlayerPrefs.GetInt("Fountain")==1){
            Fountain1.SetActive(true);
            Fountain2.SetActive(true);
            variable.var.Fountaincode=1;
                
        }
        if(PlayerPrefs.GetInt("Hovel")==1){
            Hovel.SetActive(true);
            variable.var.Hovelcode=1;   
        }
        Goldstate();
        
    }

    //저장 기능
    public void save(){
        PlayerPrefs.SetInt("Gold", variable.var.Gold);
        PlayerPrefs.SetInt("Ship", variable.var.Benchcode);
        PlayerPrefs.SetInt("Fountain", variable.var.Fountaincode);
        PlayerPrefs.SetInt("Hovel", variable.var.Hovelcode);
    }
    
    //버튼 클릭시 상점 화면 보이기
    public void shop(){   
        
        if(Shop==false){
                
                ShopUI.SetActive(true);
                Shop=true;
                ShopTxt.text="";
            }
        else{
                
                ShopUI.SetActive(false);
                Shop=false;
                ShopTxt.text="";
            }        
    }
    //구매 기능,구매할 경우 자동으로 정원 업데이트
    public void buyShip()
    {
        if(variable.var.Benchcode!=1){
            if(variable.var.Gold>=120)
            {
            ship.SetActive(true);
            DoubleBench.SetActive(true);
            Bench.SetActive(true);
            variable.var.Gold=variable.var.Gold-100;
            ShopTxt.text="[벤치와 조각배] 구매 완료!";
            variable.var.Benchcode=1;
            }
        
            else{
            ShopTxt.text="골드가 부족해요!";
            }
        }
        else{
             ShopTxt.text="이미 구매한 상품입니다.";
        }
        Goldstate();
    }
    public void buyFountain()
    {
        if(variable.var.Fountaincode!=1){
        if(variable.var.Gold>=150)
        {
            Fountain1.SetActive(true);
            Fountain2.SetActive(true);
            
            variable.var.Gold=variable.var.Gold-150;
            ShopTxt.text="[분수] 구매 완료!";
            variable.var.Fountaincode=1;
            
        }
        else{
            ShopTxt.text="골드가 부족해요!";
        }}
        else{
             ShopTxt.text="이미 구매한 상품입니다.";
        }
        Goldstate();
    }
    public void buyHovel()
    {
        if(variable.var.Hovelcode!=1){
        if(variable.var.Gold>=250)
        {
            Hovel.SetActive(true);
            variable.var.Gold=variable.var.Gold-200;
            ShopTxt.text="[쉼터] 구매 완료!";
            variable.var.Hovelcode=1;
        }
        else{
            ShopTxt.text="골드가 부족해요!";
        }}
        else{
             ShopTxt.text="이미 구매한 상품입니다.";
        }
        Goldstate();
    }
    //골드 상태 업데이트
    public void Goldstate()
    {
        GoldTxt.text="Gold: "+variable.var.Gold.ToString();
    }
    
}
