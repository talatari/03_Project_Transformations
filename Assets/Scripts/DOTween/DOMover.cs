using UnityEngine;
using DG.Tweening;

public class DOMover : MonoBehaviour
{
    [SerializeField] private Vector3 _distance;
    
    private void Start()
    {
        float moveTime = 3;
        Vector3 position = transform.position;
        Vector3 target = position + _distance;
        
        transform.DOMove(target, moveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}