﻿namespace Assets.Scripts.UI.InputName.Model
{
    public struct InputNameData : IInputNameData
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
