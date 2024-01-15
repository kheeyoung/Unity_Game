using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    Vector3 pos; //현재위치

float delta = 2f; // 좌(우)로 이동가능한 (x)최대값

float speed = 2.0f; // 이동속도
public GameObject crash;



void Start () {

    pos = transform.position;
}


void Update () {
//햄버거 움직이게
    Instantiate(crash,transform.position,transform.rotation);

    Vector3 v = pos;

    v.x += delta * Mathf.Sin(Time.time * speed);

    

    transform.position = v;

}
//플레이어와 닿을시 삭제
    private void OnTriggerEnter(Collider other){
        
        Destroy(gameObject,0.01f);
    }

}
