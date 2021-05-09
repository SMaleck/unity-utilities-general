using System;
using UnityEngine;

namespace UtilitiesGeneral.Utilities.Range
{
    [Serializable]
    public class FloatRange
    {
        [SerializeField] private float _from;
        [SerializeField] private float _to;

        public float From => _from;
        public float To => _to;
    }
}