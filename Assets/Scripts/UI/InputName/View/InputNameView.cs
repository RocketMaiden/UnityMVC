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

        private void Awake()
        {
            _okButton.onClick.AddListener(OnOkClick);
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
