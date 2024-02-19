using System;
namespace Multimetr
{
    public static class EventsMultimetr
    {
        public static Action<TypeValue> OnTurnSwitcher;
        public static void TurnSwithcer(TypeValue type)
        {
            OnTurnSwitcher?.Invoke(type);
        }
        public static Action<MultimetrValues, TypeValue> OnShowValues;
        public static void ShowValues(MultimetrValues values, TypeValue typeValue)
        {
            OnShowValues?.Invoke(values, typeValue);
        }

    }
}