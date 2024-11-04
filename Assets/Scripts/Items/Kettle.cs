using UnityEngine;

public class Kettle : MonoBehaviour, IInteractible
{
    public bool Interact(Interactor interactor)
    {
        return true;
    }
}
