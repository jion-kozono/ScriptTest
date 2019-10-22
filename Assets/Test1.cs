using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 20, 30, 40, 50, 60 };
        for (int i = 0; i < array.Length; i++)
        {
            //順番通りに表示する
            Debug.Log(array[i]);

            //逆順に表示する
            Debug.Log(array[array.Length - i - 1]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
