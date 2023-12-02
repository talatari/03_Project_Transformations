using UnityEngine;
using DG.Tweening;

public class DORotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 10f;
    
    private Vector3 _aroundY = new (0, 360, 0);
    
    private void Start() => 
        transform.DORotate(_aroundY, _speedRotation, RotateMode.LocalAxisAdd)
            .SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
}