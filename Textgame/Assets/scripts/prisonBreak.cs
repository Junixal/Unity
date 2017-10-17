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

        else if(Input.GetKeyDown(KeyCode.M))
        {
            myStates = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_0;
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
            "Press R to go back Cell or T to Take the Mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            myStates = States.cell_mirror;
        }
    }

    void Lock_0()
    { myText.text = "This is one of those button locks. You have no idea what the " +
          "combination is. You wish you could somehow see where the dirty " +
        "fingerprints were, maybe that would help.\n\n" +
        "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
    
    }

    void Cell_mirror()
    {
       myText.text = "You are still in your cell, and you STILL want to escape! There are " +
          "some dirty sheets on the bed, a mark where the mirror was, " +
          "and that pesky door is still there, and firmly locked!\n\n" +
          "Press S to view Sheets, or L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_1;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_1;
        }
    }

    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
        "any better.\n\n" + "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
        "so you can see the lock. You can just make out fingerprints around " +
        "the buttons. You press the dirty buttons, and hear a click.\n\n" +
        "Press O to Open, or R to Return to your cell";

        if(Input.GetKeyDown(KeyCode.O))
        {
            myStates = States.freedom;
        }

    }

    void Freedom()
    {
        myText.text = "YOU EXIT THE CELL!!, you see stairs to your right and a closet on your left" +
        "Press P if you want to serve your time." + "Press S to go up the stairs" + "Press F to search the floor" +
        "Press C to go in the closet";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = States.closet_door;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.stairs_0;
        }
        

    }

    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n" + "Press R to return to go back";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.freedom;
        }

     }

    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" + "Press H to get up with the hairpin" 
           + "Press L to leave to hairpin and get up";

        if (Input.GetKeyDown(KeyCode.H))
        {
            myStates = States.corridor_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.freedom;
        }

    }

    void Closet_door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
        "Maybe you could find something around to help enourage it open?\n\n" + "Press R to get up";

       if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.freedom;
        }
    }

    void Corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?\n\n" + "Press P to pick the lock" + "Press S to climb the stairs";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.in_closet;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.stairs_1;
        }
    }

    void Stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
    "confidence to walk out into a courtyard surrounded by armed guards!\n\n" + "press R to go down the stairs";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.corridor_1;
        }

    }

    void In_closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up.\n\n" + "Press U to change clothes";

        if (Input.GetKeyDown(KeyCode.U))
        {
            myStates = States.corridor_3;
        }
    }

    void Corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner."
            + "You strongly consider the run for freedom.\n\n" + "Press S to go to the courtyard";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.courtyard;
        }
    }

    void Courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
                "The guard tips his hat at you as you waltz past, claiming " +
        "your freedom. You heart races as you walk into the sunset.\n\n" +
        "Press P to Play again.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.cell;
        }

    }






    private enum States
    {
        cell,mirror,sheets_0,lock_0, sheets_1, lock_1,freedom,cell_mirror,stairs_0,floor,closet_door,corridor_1,stairs_1,in_closet,corridor_3,courtyard


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

        else if (myStates == States.cell_mirror)
        {
            Cell_mirror();
        }

        else if (myStates == States.sheets_1)
        {
            Sheets_1();
        }

        else if (myStates == States.lock_1)
        {
            Lock_1();
        }

        else if (myStates == States.freedom)
        {
            Freedom();
        }

        else if (myStates == States.stairs_0)
        {
            Stairs_0();
        }

        else if (myStates == States.floor)
        {
            Floor();
        }

        else if (myStates == States.closet_door)
        {
            Closet_door();
        }

        else if (myStates == States.corridor_1)
        {
            Corridor_1();
        }

        else if (myStates == States.stairs_1)
        {
            Stairs_1();
        }

        else if (myStates == States.in_closet)
        {
            In_closet();
        }

        else if (myStates == States.corridor_3)
        {
            Corridor_3();
        }

        else if (myStates == States.courtyard)
        {
            Courtyard();
        }



    }
}
