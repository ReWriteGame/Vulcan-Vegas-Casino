using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Roulette : MonoBehaviour
{
        [SerializeField] private float angleForce;
        [SerializeField] private Vector2 rangeAngleForce = new Vector2(-1, 1);

        private Rigidbody2D rb;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            //randomTwist();
        }

        public void RandomTwist()
        {
            Twist(Random.Range(rangeAngleForce.x, rangeAngleForce.y));
        }

        public void Twist(float force)
        {
            rb.AddTorque(force, ForceMode2D.Impulse);
        }

    public void StopTorque()
    {
        rb.angularVelocity = 0;
    }

}