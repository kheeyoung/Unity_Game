using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) 
    {//충돌시 클리어
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            variable.var.loadcode=5;
            SceneManager.LoadScene(3);
        }
    }
}
