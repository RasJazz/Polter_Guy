using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "ScriptableObjects/NewSO")]
public class Sprites : ScriptableObject
{
    [SerializeField] private Sprite[] _ghostSprites;
    [SerializeField] private Sprite[] _momSprites;
    [SerializeField] private Sprite[] _dadSprites;
    [SerializeField] private Sprite[] _teenSprites;
}
