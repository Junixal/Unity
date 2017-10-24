using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

    //creates 4 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;
    int maxNumberOfGuesses = 10;

    public Text guessText;

    //the number is smaller than the one guessed
    public void guessHigher()
    {
        min = guess;
        NextGuess();

    }
    //the number is larger than the one guessed
    public void guessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess =Random.Range(min,max);
        guessText.text = guess.ToString();
        maxNumberOfGuesses--;
        if(maxNumberOfGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }
        

    }

    void StartGame()
    {
        //prints once to the Console
        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number in your head between " + min + " and " + max);
        //calling method NextGuess()
        NextGuess();
    }

    // Use this for initialization
    void Start () {

        StartGame();
        
        	
	}
	

}