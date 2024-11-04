using System;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private InteractionPromptUI _interactionPromptUI;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;
    
    private IInteractible _interactible;

    private void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders,
            _interactableMask);

        if (_numFound > 0)
        {
            _interactible = _colliders[0].GetComponent<IInteractible>();
            
            if (_interactible != null)
            {
                if(!_interactionPromptUI.IsDisplayed) _interactionPromptUI.SetUp();
                if (Input.GetKey(KeyCode.E)) _interactible.Interact(this);
            }
        }
        else
        {
            if (_interactible != null) _interactible = null;
            if(_interactionPromptUI.IsDisplayed) _interactionPromptUI.Close();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}
