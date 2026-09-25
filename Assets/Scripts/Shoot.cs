using FMODUnity;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private EventReference _shootSoundEvent;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _speedForce = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GameObject bullet = Instantiate(
                _bulletPrefab,
                _spawnPoint.position,
                _spawnPoint.rotation);

            ForceBullet forceBullet = bullet.GetComponent<ForceBullet>();

            forceBullet.InsInitialize(_speedForce);

            RuntimeManager.PlayOneShot(_shootSoundEvent, _spawnPoint.position);
        }
    }
}
