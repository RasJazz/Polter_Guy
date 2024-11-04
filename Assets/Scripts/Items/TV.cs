using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour, IInteractible
{
    [SerializeField] private string _prompt;
    [SerializeField] private SpriteRenderer _changeSprite;
    [SerializeField] private Sprite _tvOn;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        _changeSprite.sprite = _tvOn;
        return true;
    }
}
