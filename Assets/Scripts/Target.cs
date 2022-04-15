using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject destroyedVersion;

    bool isDestroyd;

    public void TakeDamage(float amount)
    {      
        health -= amount;
        
        if(health <= 0f)
        {
            Die();
        }
        
        void Die()
        {
            Destroy(gameObject);

            if (!isDestroyd)
            {
                Instantiate(destroyedVersion, transform.position, transform.rotation);
                isDestroyd = true;
            }
        }
        
    }
}
