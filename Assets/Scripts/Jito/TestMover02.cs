using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using System.Threading;
using R3;
using R3.Triggers;
using System;

public class TestMover02 : MonoBehaviour
{
    public Target target;

    private void Start()
    {
        rotator = new Rotator(transform);
        this.UpdateAsObservable()
            .Where(_ => Input.GetKeyUp(KeyCode.Space))
            .ThrottleFirst(TimeSpan.FromSeconds(0.5f))
            .Subscribe( async x =>
            {
                if(cts != null)
                {
                    cts.Cancel();
                    cts.Dispose();
                }
                cts = new CancellationTokenSource();
                token = cts.Token;

                rotator.Rotate(token).Forget();
                await UniTask.WaitForSeconds(0.1f);
                if (target == null)
                {
                    return;
                }
                target.Rotate().Forget();

            }).AddTo(this);
    }

    Rotator rotator;

    CancellationTokenSource cts;
    CancellationToken token;
    // Update is called once per frame
}
