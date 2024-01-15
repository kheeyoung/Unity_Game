using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    public static variable var;
    //변수
    public int Gold;
    public int Benchcode;
    public int Fountaincode;
    public int Hovelcode;
    public int loadcode;
    public int load;
    public int blocknum;
 
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if(var==null)
        {
            var=this;
        }
    }
}
