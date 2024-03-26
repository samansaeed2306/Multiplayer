using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatter : MonoBehaviour
{
    private SpriteRenderer rend;
    [SerializeField] Sprite[] blood;
    private void Start()

    {

        rend = GetComponentInChildren<SpriteRenderer>();

        int rand = Random.Range(0, blood.Length);

        rend.sprite = blood[rand];
    }

}