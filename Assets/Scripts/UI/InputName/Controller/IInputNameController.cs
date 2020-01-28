using Assets.Scripts.UI.InputName.Model;
using Assets.Scripts.UI.InputName.View;
using System;

namespace Assets.Scripts.UI.InputName.Controller
{
    public interface IInputNameController
    {
        event Action<IInputNameDataReadOnly> TextInput;
        void Initialize(IInputNameData model, IInputNameView view);        
    }
}
