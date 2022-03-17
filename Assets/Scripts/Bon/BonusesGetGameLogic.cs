using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusesGetGameLogic : MonoBehaviour
{
  [SerializeField]private ScoreCounter score;
  [SerializeField]private Bonuses bonuses;

  public void AddScore()
  {
    bonuses.AddScore(score.Score);
  }
}
