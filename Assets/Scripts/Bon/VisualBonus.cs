using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualBonus : MonoBehaviour
{
    [SerializeField] private Bonuses bonus;
    [SerializeField] private Text text;

    void Update()
    {
        text.text = $"{bonus.Value}";
    }
}
