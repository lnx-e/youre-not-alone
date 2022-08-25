using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventHelper : MonoBehaviour
{
    public UnityEvent OnAttackPerformed, TrailStart, TrailEnd;

    public void TriggerAttack()
    {
        OnAttackPerformed?.Invoke();
    }

    public void TrailBegin()
    {
        TrailStart?.Invoke();
    }

    public void TrailFinish()
    {
        TrailEnd?.Invoke();
    }
}
