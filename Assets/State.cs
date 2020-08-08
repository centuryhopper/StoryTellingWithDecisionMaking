using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
  [TextArea(10,14)][SerializeField] string storyText;
    [SerializeField] State[] states;

    public State[] States { get {return states;} }

// getters
    [Obsolete]
    public State[] NextStates()
    {
        return states;
    }

    public string GetStateStory()
    {
        return storyText;
    }
}
