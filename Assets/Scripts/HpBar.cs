using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] private float _hpChangeSpeed = 1;

    private int _targetHp = 0;
    private bool _isChanging = false;

    private Slider _hpBar;

    private void Start()
    {
        _hpBar = GetComponent<Slider>();
    }

    private void Update()
    {
        if (_isChanging)
            _hpBar.value = Mathf.MoveTowards(_hpBar.value, _targetHp, _hpChangeSpeed);
        if (_hpBar.value == _targetHp)
            _isChanging = false;
    }

    public void SetTargetHp(int targetHp)
    {
        _targetHp = targetHp;
        _isChanging = true;
    }
}
