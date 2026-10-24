using UnityEngine;

public class StunGun : MonoBehaviour
{
    [SerializeField] private float range = 15f;
    [SerializeField] private float stunDuration = 3f;
    [SerializeField] private LayerMask EnemyLayer;

    [SerializeField] private Transform firePoint;

    private void Update()
    {
        Debug.DrawRay(
        firePoint.position,
        firePoint.up * range,
        Color.cyan
    );
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Physics.Raycast(firePoint.position, firePoint.up, out RaycastHit hit, range, EnemyLayer))
        {
            EnemyAI enemy = hit.collider.GetComponentInParent<EnemyAI>();
            if (enemy != null)
            {
                enemy.Stun(stunDuration);
                return;
            }
            EnemyAIGenerated generatedEnemy =
                hit.collider.GetComponentInParent<EnemyAIGenerated>();
            if (generatedEnemy != null)
            {
                generatedEnemy.Stun(stunDuration);
            }
        }
    }
}