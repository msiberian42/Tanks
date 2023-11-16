using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Collider)), RequireComponent(typeof(Rigidbody))]
    public class Controller : MonoBehaviour
    {
        [SerializeField] private GameObject turret;

        public void Move()
        {

        }
        public void RotateTurret()
        {

        }
        public void Shoot()
        {

        }
    }
}
