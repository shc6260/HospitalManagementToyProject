using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IEquipmentContentControlView
    {
        void SetEquipmentsList(IEnumerable<Equipment> items);

        event EventHandler<Equipment> UpdateEquipRequested;
        event EventHandler<Equipment> DeleteEquipRequested;
        event EventHandler<Equipment> ToggleActiveRequested;
    }
}
