using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SanityBar : MonoBehaviour
{
    public Slider _slider;

    public void SetMaxSanity(int sanity)
    {
        _slider.maxValue = sanity;
        _slider.value = sanity;
    }

    public void SetSanity(int sanity)
    {
        _slider.value += sanity;
        Debug.Log(_slider.value);
        if (_slider.value == 0)
        {
            // Add in Scene Switcher here
            Debug.Log("They've moved out");
        }
    }
}
