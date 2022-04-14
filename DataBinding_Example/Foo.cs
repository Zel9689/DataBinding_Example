using System.ComponentModel;

namespace DataBinding_Example;

public class Foo : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public int Number
    {
        get
        {
            return _number;
        }
        set 
        {
            if (value == _number)
                return;
            _number = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));
        }
    }
    private int _number;
}
