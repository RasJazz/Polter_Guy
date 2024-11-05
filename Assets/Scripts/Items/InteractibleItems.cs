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
        // Save original position and rotation of items
        _origPosition = transform.position;
        _origRotation = transform.rotation;
    }

    protected IEnumerator WaitToReset(Animation animation)
    {
        // Plays animation, then waits x amount of seconds to put item back
        // in original spot
        yield return new WaitUntil(() => !animation.isPlaying);
        yield return new WaitForSeconds(_secondTimer);

        transform.position = _origPosition;
        transform.rotation = _origRotation;
    }
    
    protected IEnumerator WaitForTimer(GameObject _secondSprite, ItemSpriteShow objectBool)
    {
        // Shows Sprite for x seconds, then hides again
        yield return new WaitForSeconds(_secondTimer);
        _secondSprite.SetActive(false);
        objectBool.ResetInteraction();
    }
    
    public abstract void Interact();
}
