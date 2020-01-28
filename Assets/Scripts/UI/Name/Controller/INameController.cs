using Assets.Scripts.UI.Name.Model;
using Assets.Scripts.UI.Name.View;

namespace Assets.Scripts.UI.Name.Controller
{
    interface INameController
    {
        void Initialize(INameData model, INameView view);        
        void SetName(string name);
    }
}
