using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange, chaos, capsule;
    private bool isGameOver = true;
    // Flags that control the state of the game
	private float elapsedTime = 0;
	private bool isRunning = false;
	private bool isFinished = false;

 // Start is called before the first frame update
    void Start()
    {
       
    }

private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;
	}

    void Update (){
        //If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved && capsule.isSolved;

    if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}

    }
    void OnGUI(){
        

        if(!isRunning)
		{
			string message;

			if(isGameOver)
			{
				message = " Click or Press Enter to Play Again";
			}
			else
			{
				message = "Press Enter to Start the Counter";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame ();
			}
		}

        // If the player finished the game, show the final time
		if(isGameOver)
		{
			GUI.Box(new Rect(Screen.width / 2 - 95, 185, 200, 40), "Good Job! Your Time Was");
			GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
    }


    // Update is called once per frame
    
}
