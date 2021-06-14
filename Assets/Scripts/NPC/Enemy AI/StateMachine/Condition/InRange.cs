﻿using UnityEngine;
[System.Serializable]
public class InRange : Condition
{
    [SerializeField] private LayerMask whatIsTarget;
    [SerializeField] private float radius=1f;
    [SerializeField] private Transform center;
    public override bool IsMet()
    {
        if (Physics.OverlapSphere(center.position, radius, whatIsTarget).Length > 0 )
        {
            return true;
        }

        return false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(center.position, radius);
    }
}