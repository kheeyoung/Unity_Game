using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject Car_4;
    float currTime;

    void Update(){
        this.currTime += Time.deltaTime;
        //5초마다 생성
        if (currTime > 5)
          {
              // x,y,z 좌표값을 각각 다른 범위에서 랜덤하게 정해지도록 만들었다.
              float newX = Random.Range(-320f, -325f), newY = 70.2f, newZ = 95.49f;

              // 생성할 오브젝트를 불러온다.
              GameObject car = Instantiate(Car_4) as GameObject;

              // 불러온 오브젝트를 랜덤하게 생성한 좌표값으로 위치를 옮긴다.
              car.transform.position = new Vector3(newX, newY, newZ);

              // 시간을 0으로 되돌려주면, 5초마다 반복된다.
              currTime = 0;
          }    
    }
}
