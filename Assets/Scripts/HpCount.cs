using UnityEngine;
using UnityEngine.Events;

public class HpCount : MonoBehaviour
{
    [SerializeField] private int _maxHp = 100;
    [SerializeField] private HpChanged _hpChanged;

    private int _hp = 0;

    private void Start()
    {
        _hp = _maxHp;
        _hpChanged.Invoke(_hp);
    }

    public void ChangeHp(int changeValue)
    {
        _hp += changeValue;
        if (_hp > _maxHp)
            _hp = _maxHp;
        else if (_hp < 0)
            _hp = 0;
        _hpChanged.Invoke(_hp);
    }
}

[System.Serializable]
public class HpChanged : UnityEvent<int> { }
