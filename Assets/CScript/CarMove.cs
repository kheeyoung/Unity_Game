using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove : MonoBehaviour
{
    public Transform Target;
    public float speed = 1f;
    GameObject car;

    void Update()
    {//생성 이후 움직임 (앞으로 이동, 화면 나갈 시 삭제)
        transform.Translate(Vector3.forward*-speed);

        Vector3 view = Camera.main.WorldToScreenPoint(transform.position);

        if(view.y < -100)
        {Destroy(gameObject);}

    }   

    public void OnCollisionEnter(Collision collision) 
    {
        //충돌시 게임오버 화면 이동
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            variable.var.loadcode=4;
            SceneManager.LoadScene(3);
        }
    }
    
}