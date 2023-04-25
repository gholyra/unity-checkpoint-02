using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{

    [SerializeField] private int[] ints;
    // Start is called before the first frame update
    void Start()
    {
        print("Questão 1");
        print("O resultado da soma é " + ArraySum(ints) + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int ArraySum(int[] numbers)
    {
        int sum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    
}
