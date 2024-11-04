using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vase : MonoBehaviour,IInteractible
{
    [SerializeField] private string _prompt;
    [SerializeField] private SpriteRenderer _changeSprite;
    [SerializeField] private Sprite _deadFlowers;
    //private Animation _animation;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        //if (!_animation.isPlaying) _animation.Play();
        _changeSprite.sprite = _deadFlowers;
        return true;
    }
}
