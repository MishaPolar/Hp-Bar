using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;

    public event UnityAction<int> HealthChanged;

    public int MaxHealth => _maxHealth;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    public void ApplyHealthChanging(int value)
    {
        int startHealth = _health;
        if (_health + value < 0)
        {
            _health = 0;
        }
        else if (_health + value > _maxHealth)
        {
            _health = _maxHealth;
        }
        else
        {
            _health += value;
        }

        if (startHealth != _health)
            HealthChanged?.Invoke(_health);
    }

}
