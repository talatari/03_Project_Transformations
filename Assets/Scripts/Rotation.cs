using System.Collections;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _moveRotate = 200f;
    
    private void Start()
    {
        StartCoroutine(Rotate());
    }

    private void OnDisable()
    {
        StopCoroutine(Rotate());
    }
    
    private IEnumerator Rotate()
    {
        while (true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * _moveRotate);
            yield return null;
        }
    }
}
