using Assets.Scripts.UI.Name.Model;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Assets.Scripts.UI.Name.View
{
    public class NameView : MonoBehaviour, INameView
    {
        [SerializeField]
        private Text _name = null;

        [SerializeField]
        private Button _buttonToActivateInput = null;

        public event Action ActivateInput;

        private void Awake()
        {
            _buttonToActivateInput.onClick.AddListener(OnButtonToActivateInputClick);
        }
        private void OnDestroy()
        {
            _buttonToActivateInput.onClick.RemoveListener(OnButtonToActivateInputClick);
        }

        private void OnButtonToActivateInputClick()
        {
            if (ActivateInput != null)
            {
                ActivateInput.Invoke();
            }
        }

        public void SetName(INameDataReadOnly model)
        {            
            _name.text = model.GetName(); 
        }


    }
}
