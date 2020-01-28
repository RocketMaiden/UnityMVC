using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.InputName.View
{
    public class InputNameView : MonoBehaviour, IInputNameView
    {
        [SerializeField]
        private Button _okButton = null;
        [SerializeField]
        private Text _text = null;
        public event Action<string> TextInput;

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        private void Awake()
        {
            _okButton.onClick.AddListener(OnOkClick);
        }

        private void OnDestroy()
        {
            _okButton.onClick.RemoveListener(OnOkClick);
        }

        private void OnOkClick()
        {
            if(TextInput!= null)
            {
                TextInput.Invoke(_text.text);
            }

        }       
    }
}
