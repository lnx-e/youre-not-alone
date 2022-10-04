using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventHelper : MonoBehaviour
{
    public UnityEvent OnAttackPerformed, OnFinishedAttack;

    public void TriggerAttack()
    {
        OnAttackPerformed?.Invoke();
    }

    public void FinishAttack()
    {
        OnFinishedAttack?.Invoke();
    }
}
