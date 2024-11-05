using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpriteShow : InteractibleItems
{
    [SerializeField] private SanityBar _sanityBar;
    [SerializeField] private int _sanityValue;
    [SerializeField] private GameObject _secondSprite;
    private bool isInteracting = false;
    
    public override void Interact()
    {
        if (isInteracting) return;

        isInteracting = true;
        _sanityBar.SetSanity(_sanityValue);
        _secondSprite.SetActive(true);
        StartCoroutine(WaitForTimer(_secondSprite, this));
    }
    
    public void ResetInteraction()
    {
        isInteracting = false;
    }
}
