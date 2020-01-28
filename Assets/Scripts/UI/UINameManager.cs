using System;
using Assets.Scripts.UI.InputName.Controller;
using Assets.Scripts.UI.InputName.Model;
using Assets.Scripts.UI.InputName.View;
using Assets.Scripts.UI.Name.Controller;
using Assets.Scripts.UI.Name.Model;
using Assets.Scripts.UI.Name.View;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class UINameManager : MonoBehaviour
    {
        [SerializeField]
        private NameView _nameView = null;
        [SerializeField]
        private InputNameView _inputNameView = null;

        private INameController _nameController;
        private IInputNameController _inputNameController;

        private void Awake()
        {                      
            _nameController = new NameController();
            _nameController.Initialize(new NameData(), _nameView);
            _nameController.SetName("user");
            _nameController.ActivateInput += OnActivateInput;

            _inputNameController = new InputNameController();
            _inputNameController.Initialize(new InputNameData(), _inputNameView);
            _inputNameController.TextInput += OnTextInput;

        }
        private void OnDestroy()
        {
            _nameController.ActivateInput -= OnActivateInput;
            _inputNameController.TextInput -= OnTextInput;
        }

        private void OnActivateInput()
        {
            _inputNameController.Activate();
        }

        private void OnTextInput(IInputNameDataReadOnly model)
        {
            _nameController.SetName(model.GetName());
        }
    }
}
