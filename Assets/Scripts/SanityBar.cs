using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SanityBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void SetMaxSanity(int sanity)
    {
        _slider.maxValue = sanity;
        _slider.value = sanity;
    }

    public void SetSanity(int sanity)
    {
        _slider.value = sanity;
    }
}
