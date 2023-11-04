using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _distanceTarget = 5f;
    [SerializeField] private float _moveSpeed = 10f;

    private void Start()
    {
        StartCoroutine(Move());
    }

    private void OnDisable()
    {
        StopCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            while (transform.position.z != _distanceTarget)
            {
                Vector3 targetPoint = new Vector3(transform.position.x, transform.position.y, _distanceTarget);
                transform.position = Vector3.MoveTowards(transform.position, targetPoint, Time.deltaTime * _moveSpeed);
                yield return null;
            }

            _distanceTarget *= -1;
        }
    }
}