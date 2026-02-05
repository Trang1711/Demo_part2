using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
	public GameObject bulletPrefabs;
	public float shootingInterval;
	public Vector3 bulletOffset;

	private float lastBulletTime;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			UpdateFiring();
		}
	}

	private void UpdateFiring()
	{
		if (Time.time - lastBulletTime > shootingInterval)
		{
			ShootBullet();
			lastBulletTime = Time.time;
		}
	}

	private void ShootBullet()
	{
		var bullet = Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
	}
}