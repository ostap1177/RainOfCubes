using System.Collections;
using UnityEngine;

public class DestroyerCube : MonoBehaviour
{
    [SerializeField] private int _delayDestroy;

    private Coroutine _destroyCoroutine;
    private WaitForSeconds _waitForSeconds;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_delayDestroy);
    }

    public void DestroyCube()
    {
        if (_destroyCoroutine != null)
        {
            StopCoroutine(_destroyCoroutine);
        }

        _destroyCoroutine = StartCoroutine(DelaySpawnOre());
    }

    private IEnumerator DelaySpawnOre()
    {
        yield return _waitForSeconds;
            
        Destroy();
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
