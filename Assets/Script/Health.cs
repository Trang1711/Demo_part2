using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; 
    public int defaultHealthPoint = 3; 
    public int healthPoint;     

    public System.Action onHealthChanged;    
    
    public System.Action onDead;
    private void Start()
    {
        healthPoint = defaultHealthPoint; 
        onHealthChanged?.Invoke();
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return; 

        healthPoint -= damage;
        onHealthChanged?.Invoke();
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
        onDead?.Invoke();
    }
}