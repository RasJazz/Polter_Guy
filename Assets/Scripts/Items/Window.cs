using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour,IInteractible
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    
    public bool Interact(Interactor interactor)
    {
        Debug.Log(_prompt);
        return true;
    }
}
