using System;
using UnityEngine;
using UnityEngine.Events;

public class BonusTimeGetLogic : MonoBehaviour
{
    [SerializeField] private Bonuses bonuses;
    [SerializeField] private int timeGetBonuses = 30;
    [SerializeField] private int addBonus = 10;
    [SerializeField] private GameObject button;
    
    public UnityEvent activateTimeEvent;
    public UnityEvent updateActivateTimeEvent;




    public void Activate()
    {
        activateTimeEvent?.Invoke();
        bonuses.SetLastTime(GetCurrentTimeInMinutes());
        bonuses.AddScore(addBonus);

    }
 
    private void FixedUpdate()
    {
        button.SetActive(CanGetBonus() ? true : false);

        if (CanGetBonus())
        {
            updateActivateTimeEvent?.Invoke();
        }
    }


    private bool CanGetBonus()
    {
        return Mathf.Abs(bonuses.LastReceivedTime - GetCurrentTimeInMinutes()) >= timeGetBonuses;
    }

    private int GetCurrentTimeInMinutes()
    {
      return DateTime.Now.Hour * 60 + DateTime.Now.Minute;
    }
}
//todo переписать систему 
