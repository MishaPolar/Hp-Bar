using UnityEngine;
using UnityEngine.UI;

public class HpCount : MonoBehaviour
{
    [SerializeField] private float _VisualChangeSpeed = 3;
    [SerializeField] private Slider HpBar;
    [SerializeField] private int _maxHp = 100;

    private int _hp;

    private void Start()
    {
        _hp = _maxHp;
        HpBar.value = _hp;
        HpBar.maxValue = _maxHp;
    }

    public void ChangeHp(int changeValue)
    {
        _hp += changeValue;
        if (_hp > _maxHp)
            _hp = _maxHp;
        else if (_hp < 0)
            _hp = 0;
    }

    private void Update()
    {
        if (HpBar.value != _hp)
            HpBar.value = Mathf.MoveTowards(HpBar.value, _hp, _VisualChangeSpeed);
    }
}
