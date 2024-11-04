using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour,IInteractible
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    
    public bool Interact(Interactor interactor)
    {
        // Tip chair over
        transform.rotation = Quaternion.Euler(0, 0, -90);
        Debug.Log(_prompt);
        return true;
    }
}
