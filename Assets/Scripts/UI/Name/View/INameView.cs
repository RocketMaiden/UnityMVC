
using Assets.Scripts.UI.Name.Model;
using System;

namespace Assets.Scripts.UI.Name.View
{
    public interface INameView
    {       
        void SetName(INameDataReadOnly model);
        event Action ActivateInput;
    }
}
