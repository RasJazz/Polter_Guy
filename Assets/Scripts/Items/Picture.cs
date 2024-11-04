using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Picture : InteractibleItems
{
    [SerializeField] private Animation _animation;
    [SerializeField] private SanityBar _sanityBar;
    [SerializeField] private int _sanityValue;

    public override bool Interact(Interactor interactor)
    {
        if (!_animation.isPlaying)
        {
            _sanityBar.SetSanity(_sanityValue);
            _animation.Play();
            StartCoroutine(WaitToReset(_animation));
        }

        return true;
    }
}
