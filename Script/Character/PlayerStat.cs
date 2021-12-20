using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : Stat
{
    [SerializeField]
    protected int _power;
    [SerializeField]
    protected int _speed;
    [SerializeField]
    protected int _inteligence;
    [SerializeField]
    protected int _luck;

    public int Power { get { return _power; } set { _power = value; } }
    public int Speed { get { return _speed; } set { _speed = value; } }
    public int Inteligence { get { return _inteligence; } set { _inteligence = value; } }
    public int Luck { get { return _luck; } set { _luck = value; } }

    private void Start()
    {
        _power = 100;
        _speed = 30;
        _inteligence = 30;
        _luck = 30;
    }
}
