using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractibleItems : MonoBehaviour,IInteractible
{
    private float _secondTimer = 3f;
    protected Vector3 _origPosition;
    protected Quaternion _origRotation;

    protected virtual void Awake()
    {
        _origPosition = transform.position;
        _origRotation = transform.rotation;
    }

    protected IEnumerator WaitToReset(Animation animation)
    {
        yield return new WaitUntil(() => !animation.isPlaying);
        yield return new WaitForSeconds(_secondTimer);

        transform.position = _origPosition;
        transform.rotation = _origRotation;
    }
    
    public abstract bool Interact(Interactor interactor);
}
