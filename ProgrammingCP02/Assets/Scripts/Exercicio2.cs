using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{

    [SerializeField] private string[] words;
    [SerializeField] private char letter;

    // Start is called before the first frame update
    void Start()
    {
        print("Questão 2");
        print(VerifyString(words, letter));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string[] VerifyString(string[] words, char letter)
    {
        int matchedWords = 0;
        string[] finalWords;

        foreach (string word in words)
        {
            foreach(char c in word)
            {
                if (c == letter)
                {
                    matchedWords++;
                }
            }
        }
        finalWords = new string[matchedWords];
        for(int i = 0; i < finalWords.Length; i++)
        {
            foreach (string word in words)
            {

                finalWords[i] = word;
 
            }
        }
        return finalWords;
    }

}