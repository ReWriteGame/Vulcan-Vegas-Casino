using UnityEngine;

[CreateAssetMenu(fileName = "Bonuses", menuName = "ScriptableObjects/Bonuses", order = 1)]
public class Bonuses : ScriptableObject
{
    [SerializeField] private float value = 0;
    [SerializeField] private int lastReceivedTime = 0;

    public float Value => value;
    public int LastReceivedTime => lastReceivedTime;

    public void SetLastTime(int value)
    {
        lastReceivedTime = value;
    }

    public void AddScore(float value)
    {
        this.value += value;
    }
}

