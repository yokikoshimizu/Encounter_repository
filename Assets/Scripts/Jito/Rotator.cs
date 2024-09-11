using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotator
{
    public Rotator(Transform applyTransform)
    {
        transform = applyTransform;
    }

    Transform transform;
    public async UniTask Rotate(CancellationToken token)
    {
        Debug.Log(transform.gameObject.name);
        float duration = 2.0f;
        while (duration > 0 && !token.IsCancellationRequested)
        {
            transform.Rotate(new Vector3(2, 0, 0));
            duration -= 0.01f;
            await UniTask.WaitForSeconds(0.01f);
        }

    }
}
