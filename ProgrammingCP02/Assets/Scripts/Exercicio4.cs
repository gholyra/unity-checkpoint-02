using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private int[] array = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        print("Quest�o 4");
        print("O resultado da soma � " + ArraySum(array) + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int ArraySum(int[] array)
    {
        int sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

}
