// 
using UnityEngine;
using System.Collections;

public class BloodParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem system;
    public float interval = 0.5f;

    private void Start()
    {
        StartCoroutine(TriggerSubEmitter());
    }

    private IEnumerator TriggerSubEmitter()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            system.TriggerSubEmitter(0);
        }
    }
}
