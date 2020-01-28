using Assets.Scripts.UI.Name.Model;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Name.View
{
    public class NameView : MonoBehaviour, INameView
    {
        [SerializeField]
        private Text _name = null;

        public void SetName(INameDataReadOnly model)
        {            
            _name.text = model.GetName(); 
        }
    }
}
