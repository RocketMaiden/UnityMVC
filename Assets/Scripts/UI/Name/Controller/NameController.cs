using System;
using Assets.Scripts.UI.Name.Model;
using Assets.Scripts.UI.Name.View;

namespace Assets.Scripts.UI.Name.Controller
{
    public class NameController : INameController
    {
        public event Action ActivateInput;

        private INameData _model;
        private INameView _view;

        public void Initialize(INameData model, INameView view)
        {
            _model = model;
            _view = view;
            _view.SetName(_model);

            _view.ActivateInput += OnActivateInput;
        }

        private void OnActivateInput()
        {
            if (ActivateInput != null)
            {
                ActivateInput.Invoke();
            }
        }

        public void SetName(string name)
        {
            _model.SetName(name);
            _view.SetName(_model);
        }        
    }
}
