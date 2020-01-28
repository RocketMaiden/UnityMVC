namespace Assets.Scripts.UI.Name.Model
{
    public struct NameData : INameData
    {
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;           
        }
    }
}
