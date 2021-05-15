using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _ChangeSpeed;
    [SerializeField] private Health _health;

    private int _targetHealth;
    private bool IsHealthChanging = false;

    private Slider _healthSlider;

    private void Start()
    {
        _healthSlider = GetComponent<Slider>();
        _healthSlider.maxValue = _health.MaxHealth;
    }

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int value)
    {
        _targetHealth = value;

        if (IsHealthChanging == false)
            StartCoroutine(ChangingHealth());

    }

    private IEnumerator ChangingHealth()
    {
        IsHealthChanging = true;

        while(_healthSlider.value != _targetHealth)
        {
            float healthDelta = _ChangeSpeed * Time.deltaTime;
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, _targetHealth, healthDelta);
            yield return null;
        }

        IsHealthChanging = false;
    }

}
