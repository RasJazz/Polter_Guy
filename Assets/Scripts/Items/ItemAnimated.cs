using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnimated : InteractibleItems
{
    [SerializeField] private Animation _animation;
    [SerializeField] private SanityBar _sanityBar;
    [SerializeField] private int _sanityValue;
    

    public override void Interact()
    {
        // Decreases sanity and waits x amount of seconds to reset item
        if (!_animation.isPlaying)
        {
            _sanityBar.SetSanity(_sanityValue);
            _animation.Play();
            StartCoroutine(WaitToReset(_animation));
        }
        
        // Play audio
        AudioManager.Instance.PlaySFX();
    }
}
