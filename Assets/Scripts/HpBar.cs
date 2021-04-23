using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] private float _hpChangeSpeed = 1;
    [SerializeField] private HpCount _hpCount;

    private Slider _hpBar;

    private void Start()
    {
        _hpBar = GetComponent<Slider>();
    }

    private void Update()
    {
        if (_hpBar.value != _hpCount.Hp)
            _hpBar.value = Mathf.MoveTowards(_hpBar.value, _hpCount.Hp, _hpChangeSpeed);
    }
}
