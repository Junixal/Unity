using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //creates 3 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;


    void NextGuess()
    {
        print("Is the number greater or smaller than" + guess + "?");
        print("UP: Greater DOWN: Smaller ENTER: Equal");
        
    }

    void StartGame()
    {
        //prints once to the Console
        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number in your head between" + min + " and " + max);
        //Calling method
        NextGuess();
    }

    // Use this for initialization
    void Start ()
    {
        StartGame();

    }
	
	// Update is called once per frame
	void Update () {

        //if the input from the keyboard is UP Arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UP Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();

        }

        else

        //if the input from the keyboard is Down Arrow
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();

        }


        //if the input from keyboard is ENTER
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER pressed");
            print("YOU WON!! the number was" + guess);
        }






    }
}
