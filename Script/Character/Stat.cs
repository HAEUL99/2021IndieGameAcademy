using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField]
    protected int _hp;

    [SerializeField]
    protected int _defense;
    [SerializeField]
    protected int _attack;

    public int Hp { get { return _hp;  } set { _hp = value; } }

    public int Defense { get { return _defense; } set { _defense = value; } }
    public int Attack { get { return _attack; } set { _attack = value; } }

    private void Start()
    {
        _hp = 100;
        _defense = 30;

    }
}
