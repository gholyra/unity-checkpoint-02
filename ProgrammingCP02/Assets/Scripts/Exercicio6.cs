using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio6 : MonoBehaviour
{

    [SerializeField] private int[] elements = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        print("Questão 6");
        PrintElements(elements);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintElements(int[] elements)
    {
        foreach(int element in elements)
        {
            print(element);
        }
    }

}
