using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIData : MonoBehaviour
{
    public List<Transform> targets = null;  //in case of multiple targets to set AI to choose what to attack
    public Collider2D[] obstacles = null;   //store all obstacles that enemy has to avoid

    public Transform currentTarget;

    public int GetTargetsCount() => targets == null ? 0 : targets.Count;   //to save from null exeption error
}
