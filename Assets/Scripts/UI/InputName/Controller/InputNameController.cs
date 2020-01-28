using Assets.Scripts.UI.InputName.Model;
using Assets.Scripts.UI.InputName.View;
using System;

namespace Assets.Scripts.UI.InputName.Controller
{
    public class InputNameController : IInputNameController
    {
        public event Action<IInputNameDataReadOnly> TextInput;

        private IInputNameData _model;
        private IInputNameView _view;

        public void Initialize(IInputNameData model, IInputNameView view)
        {
            _model = model;
            _view = view;            

            _view.TextInput += OnTextInput;
        }       

        public void SetName(string name)
        {
            _model.SetName(name);            
        }

        private void OnTextInput(string name)
        {
            SetName(name);
            if (TextInput != null)
            {
                TextInput.Invoke(_model);
            }
        }

        
    }
}
