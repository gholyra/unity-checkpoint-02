using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    [SerializeField] private int number;
    // Start is called before the first frame update
    void Start()
    {
        print("Questão 3");
        print(VerifyNumber(number));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool VerifyNumber(int number)
    {
        int dividends = 0;
        for(int i = number; i > 0; i--)
        {
            if(number % i == 0)
            {
                dividends++;
            }
        }
        if (dividends == 2)
        {
            return true;
        }
        return false;
    }

}
