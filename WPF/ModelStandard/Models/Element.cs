using ModelStandard.Interfaces.Models;
using Prism.Mvvm;
using System;

namespace ModelStandard.Models
{
    public abstract class Element : BindableBase, IElement
    {
        #region Fields

        private string _name;

        #endregion Fields

        #region Properties

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Id { get; }

        #endregion Properties

        #region Constructor

        protected Element(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        #endregion Constructor
    }
}