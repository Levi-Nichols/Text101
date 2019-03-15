using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();   
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i) || (Input.GetKeyDown(KeyCode.Keypad1 + i)))
            {
                state = nextStates[i];

                textComponent.text = state.GetStateStory();
            }
            //else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.Escape))
            //{
                //For closing out Windows Application
                //Application.Quit();

                //For ending runtime in Unity Editor
                //UnityEditor.EditorApplication.isPlaying = false;
            //}
        }
    }

    //private void ManageState()
    //{
    //    var nextState = state.GetNextStates();

    //    if (Input.GetKeyDown(KeyCode.Alpha1) || (Input.GetKeyDown(KeyCode.Keypad1)))
    //    {
    //        state = nextState[0];
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha2) || (Input.GetKeyDown(KeyCode.Keypad2)))
    //    {
    //        state = nextState[1];
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha3) || (Input.GetKeyDown(KeyCode.Keypad3)))
    //    {
    //        state = nextState[2];
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Q) || (Input.GetKeyDown(KeyCode.Escape)))
    //    {
    //        //For closing out Windows Application
    //        //Application.Quit();

    //        //For ending runtime in Unity Editor
    //        UnityEditor.EditorApplication.isPlaying = false;
    //    }

    //    textComponent.text = state.GetStateStory();
    //}
}
