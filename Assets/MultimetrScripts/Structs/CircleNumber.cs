public struct CircularCounter
{
    private int _currentValue;
    private readonly int _maxValue;

    public CircularCounter(int maxValue)
    {
        _maxValue = maxValue;
        _currentValue = 1;
    }
  
    public int Increment()
    {
        _currentValue = _currentValue % _maxValue+1;
        return _currentValue;
    }

    public int Decrement()
    {
        if (_currentValue == 1)
        {
            _currentValue = _maxValue;
        }
        else
        {
            _currentValue -= 1;
        }
        return _currentValue;
    }

    public int CurrentValue => _currentValue;
}