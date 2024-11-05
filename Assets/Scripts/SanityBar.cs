using UnityEngine;
using UnityEngine.UI;

public class SanityBar : MonoBehaviour
{
    [SerializeField] private GameObject _levelEnd;
    [SerializeField] private GameObject _entity;
    public Slider _slider;

    public void SetMaxSanity(int sanity)
    {
        // Set sanity max level
        _slider.maxValue = sanity;
        _slider.value = sanity;
    }

    // Function to control sanity bar
    public void SetSanity(int sanity)
    {
        _slider.value += sanity;
        Debug.Log(_slider.value);
        if (_slider.value == 0)
        {
            _entity.SetActive(false);
            // Brings up end level and switches scenes
            _levelEnd.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
