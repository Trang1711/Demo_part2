using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public GameObject explosionPrefab;

	private void OnTriggerEnter2D(Collider2D collision) => Die();

	private void Die()
	{
		var explosion = Instantiate(explosionPrefab, transform.position,
		transform.rotation);
		Destroy(explosion, 1);
		Destroy(gameObject);
	}
}