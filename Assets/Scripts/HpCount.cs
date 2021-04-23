using UnityEngine;
using UnityEngine.UI;

public class HpCount : MonoBehaviour
{
    [SerializeField] private int _maxHp = 100;

    private int _hp;
    public int Hp { get => _hp;}

    private void Start()
    {
        _hp = _maxHp;
    }

    public void ChangeHp(int changeValue)
    {
        _hp += changeValue;
        if (_hp > _maxHp)
            _hp = _maxHp;
        else if (_hp < 0)
            _hp = 0;
    }
}
