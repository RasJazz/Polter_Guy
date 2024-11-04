using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyMember : MonoBehaviour
{
    [SerializeField] private int _maxSanity;
    private int _currentSanity;
    public SanityBar _sanityBar;
    // Start is called before the first frame update
    void Start()
    {
        _currentSanity = _maxSanity;
        _sanityBar.SetMaxSanity(_maxSanity);
    }

    // Update is called once per frame
    void Update()
    {
        _sanityBar.SetSanity(_currentSanity -= 1);
    }
}
