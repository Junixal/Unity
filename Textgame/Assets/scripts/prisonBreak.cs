using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prisonBreak : MonoBehaviour {

    public Text myText;

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape.There are " +
                "some dirty sheets on the bed, a mirror on the wall, and the door " +
                " is locked from the outside.\n\n" +
                "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_0;
        }
    }

    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's "
                + "time somebody changed them. The pleasures of prison life " +
                    "I guess!\n\n" + "Press R to Return to roaming your cell";

        if(Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

    }

    void Mirror()
    {

        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
            "some dirty sheets on the bed, a mark where the mirror was, " +
            "and that pesky door is still there, and firmly locked!\n\n" +
            "Press S to view Sheets, or L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_0;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_0;
        }
    }

    void Lock_0()
    { myText.text = "This is one of those button locks. You have no idea what the " +
          "combination is. You wish you could somehow see where the dirty " +
        "fingerprints were, maybe that would help.\n\n" +
        "Press R to Return to roaming your cell";

    }

    void Cell_mirror()
    {
       myText.text = "You are still in your cell, and you STILL want to escape! There are " +
          "some dirty sheets on the bed, a mark where the mirror was, " +
          "and that pesky door is still there, and firmly locked!\n\n" +
          "Press S to view Sheets, or L to view Lock";

    }


    private enum States
    {
        cell,mirror,sheets_0,lock_0, sheets_1, lock_1,freedom


    };

    private States myStates;



	// Use this for initialization
	void Start () {


        myStates = States.cell;
		
	}

    // Update is called once per frame
    void Update() {

        print(myStates);
        if (myStates == States.cell)
        {
            Cell();
        }

        else if (myStates == States.sheets_0)
        {
            Sheets_0();
        }

        else if (myStates == States.mirror)
        {
            Mirror();
        }

        else if (myStates == States.lock_0)
        {
            Lock_0();
        }

        else if (myStates == States.mirror)
        {
            Cell_mirror();
        }


    }
}
