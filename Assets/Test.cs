using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // declare and init array
        int[] points = new int[5] { 1, 3, 5, 7, 9 };

        // display all elements
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        // display all elements rev
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[points.Length - 1 - i]);
        }

        // MonoBehaviourクラスはnewできないらしいので
        Boss firstBoss = gameObject.AddComponent<Boss>();

        // Magicを10回実行
        for (int i = 0; i < 10; i++)
        {
            firstBoss.Magic();
        }
        // Magicの実行11回目
        firstBoss.Magic();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


