using System;

namespace Assets.Scripts.UI.InputName.View
{
    public interface IInputNameView
    {
        event Action<string> TextInput;                      
    }
}
