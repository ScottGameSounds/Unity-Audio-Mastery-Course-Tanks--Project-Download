using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class PowerUp : MonoBehaviour
    {
        public GameObject spawnParticles;
        public GameObject MeshObject;

        public float effectTime = 10f;
        public float destroyObjectDelay = 2f;


        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == 9)
            {
                PowerUpEffect(other);
            }
        }

        void PowerUpEffect(Collider player)
        {
            Instantiate(spawnParticles, transform.position, transform.rotation);

            TankShooting Tank = player.GetComponent<TankShooting>();
            Tank.applyBonusPower = true;
            Tank.effectTime = effectTime;
            Tank.Timer = effectTime;

            GetComponent<SphereCollider>().enabled = false;
            MeshObject.SetActive(false);

            Destroy(gameObject, destroyObjectDelay);
        }
    }
}

