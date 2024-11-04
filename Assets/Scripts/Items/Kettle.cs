using UnityEngine;

public class Kettle : MonoBehaviour, IInteractible
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    
    public bool Interact(Interactor interactor)
    {
        return true;
    }
}
