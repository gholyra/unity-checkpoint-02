using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio5 : MonoBehaviour
{

    [SerializeField] private string[] array = new string[3];
    // Start is called before the first frame update
    void Start()
    {
        print("Questão 5");
        EqualsA(array);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EqualsA(string[] array)
    {
        foreach (string word in array)
        {
            foreach (char letter in word)
            {
                if (letter == 'a' || letter == 'A')
                {
                    print(word);
                    break;
                }
            }
        }
    }

}
