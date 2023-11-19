using UnityEngine;
using UnityEngine.Assertions;
using NaughtyAttributes;

namespace Player
{
    [RequireComponent(typeof(Collider)), RequireComponent(typeof(Rigidbody))]
    public class Controller : MonoBehaviour
    {
        [SerializeField] private GameObject turret;

        public void Move()
        {

        }
        public void RotateTurret(Vector3 target)
        {
            Debug.Log(target);
            turret.transform.LookAt(new Vector3(target.x, turret.transform.position.y, target.z));
        }
        public void Shoot()
        {

        }
        [Button]
        private void TestDebug()
        {
            Assert.IsNotNull(turret);
        }
    }
}
