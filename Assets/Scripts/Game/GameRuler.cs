using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private int numberOfStart = 5;
    [SerializeField] private int scoreForWin = 5;

    public UnityEvent winEvent;
    public UnityEvent loseEvent;

    private int countStarts = 0;


    public void StartGame()
    {
        countStarts++;
        if (countStarts < numberOfStart)
        {
            scoreCounter.Add(arrow1.collidedObject.GetComponent<Cell>().Value);
        }
        else
        {
            if(scoreForWin <= scoreCounter.Score) winEvent?.Invoke();
            else loseEvent?.Invoke();
        }
    }

    private IEnumerator StopMachineCor()
    {
        yield break;
    }
}
