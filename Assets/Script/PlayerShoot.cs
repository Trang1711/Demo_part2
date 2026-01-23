using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
	public GameObject bulletPrefabs;
	public float shootingInterval;
	private float lastBulletTime;
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			if (Time.time - lastBulletTime >
			shootingInterval)
			{
				ShootBullet();
				lastBulletTime = Time.time;
			}
		}
	}

	private void ShootBullet()
	{
		Instantiate(bulletPrefabs, transform.position, transform.rotation);
	}
}