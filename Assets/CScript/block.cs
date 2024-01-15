using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class block : MonoBehaviour
{
    public GameObject crash;
    

    void Start()
    {//블럭 총 개수
        variable.var.blocknum=33;
    }

    public void OnCollisionEnter(Collision collision) 
    {//공과 닿으면 삭제
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            
            variable.var.blocknum=variable.var.blocknum-1;
            Instantiate(crash,transform.position,transform.rotation);
            Destroy(gameObject,0.01f);
        }
    }
    void Update()
    {//다 깨면 클리어
        if(variable.var.blocknum==0){
            variable.var.loadcode=5;
            SceneManager.LoadScene(3);
        }
    }
}
