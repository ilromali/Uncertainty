using System.Collections.Generic;
using NPC.Enemy_AI;
using UnityEngine;

namespace NPC
{
    /// <summary>
    /// this class handles bots needs and sets diffrent dependencies for weapons and stuff
    /// </summary>
    [RequireComponent(typeof(EnemyMoveDataContainer))]
    public class WaspBot : MonoBehaviour
    {
        private EnemyMoveDataContainer _container;

        private void OnEnable()
        {
            if (_container == null)
                _container = GetComponent<EnemyMoveDataContainer>();
        }

        public void SetPathPoints(List<Transform> points) => _container.pathPoints = points;

        public void SetSpeed(float speed) => _container.speed = speed;

        public void ReturnToPool() => WaspBotPool.Instance.ReturnToPool(this);

        public void ReduceNumberOfAliveBots()
        {
        }
    }
}