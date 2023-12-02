using DG.Tweening;
using UnityEngine;

public class DORotator : MonoBehaviour
{
    private void Start()
    {
        Vector3 around = new Vector3(0, 360, 0);
        float timeRotate = 10f;

        transform.DORotate(around, timeRotate, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.Linear);
    }
}