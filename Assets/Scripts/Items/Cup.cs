using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour,IInteractible
{
    [SerializeField] private string _prompt;
    [SerializeField] private Animation _animation;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        if (!_animation.isPlaying) _animation.Play();
        return true;
    }
}
