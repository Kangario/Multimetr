using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Multimetr
{
    public class CalculateMultimetr : MonoBehaviour , ICalculateMultimetr
    {
        [SerializeField] private float resistance;
        [SerializeField] private float power;
        private MultimetrValues values;
        private void Start()
        {
            EventsMultimetr.OnTurnSwitcher += ValueFilter;
        }
        public void ValueFilter(TypeValue type)
        {
            values = new MultimetrValues(0, 0, 0, 0);
            switch (type)
            {
                case TypeValue.resistance:
                    values.resistance = ResistanceCalculate();
                    break;
                case TypeValue.currentStrangth:
                    values.currentStrangth = (float)currentStrangthCalculate();
                    break;
                case TypeValue.voltageDC:
                    values.voltageDC = (float)VoltageDCCalculate();
                    break;
                case TypeValue.voltageAC:
                    values.voltageAC = (float)VoltageACCalculate();
                    break;
            }
            EventsMultimetr.OnShowValues(values, type);
        }
        public float ResistanceCalculate()
        {
            return resistance;
        }
        public double currentStrangthCalculate()
        {
            double currentStrangth = Math.Sqrt(power / resistance);
            return Math.Round(currentStrangth, 2);
        }
        public double VoltageDCCalculate()
        {
            return Math.Round(Math.Sqrt(power * resistance), 2);
        }
        public double VoltageACCalculate()
        {
            return Math.Round((Math.Sqrt(power / resistance) * resistance), 2);
        }
    }
}