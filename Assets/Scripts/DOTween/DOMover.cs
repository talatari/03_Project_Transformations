using UnityEngine;
using DG.Tweening;

public class DOMover : MonoBehaviour
{
    private void Start()
    {
        float _distance = 5f;
        float _moveTime = 3;
        Vector3 position = transform.position;
        Vector3 target = new Vector3(position.x, position.y, position.z + _distance);
        
        transform.DOMove(target, _moveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}