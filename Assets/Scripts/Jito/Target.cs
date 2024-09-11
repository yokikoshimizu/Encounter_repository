using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Target target;
    // Start is called before the first frame update
    void Start()
    {
        rotator = new Rotator(transform);
    }

    public Rotator rotator;

    CancellationTokenSource cts;
    CancellationToken token;

    public async UniTask Rotate()
    {
        if (cts != null) 
        {
            cts.Cancel();
            cts.Dispose();
        }

        cts = new CancellationTokenSource();
        token = cts.Token;
        rotator.Rotate(token).Forget();
        await UniTask.WaitForSeconds(0.1f);
        if(target == null)
        {
            return;
        }
        target.Rotate().Forget();
    }

}
