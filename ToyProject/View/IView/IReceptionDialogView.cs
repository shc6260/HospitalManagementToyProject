using System;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IReceptionDialogView
    {
        IReceptionControlView IReceptionControlView { get; }

        event EventHandler<Patient> LoadRequest;

        event EventHandler CancelReceptionRequest;

        event EventHandler SaveReceptionRequest;
    }
}
