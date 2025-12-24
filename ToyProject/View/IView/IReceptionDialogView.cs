using System;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IReceptionDialogView
    {
        IReceptionControlView IReceptionControlView { get; }

        event EventHandler<Patient> LoadRequestByPatient;

        event EventHandler<ReceptionWithPatientSimpleResponse> LoadRequestByReceptionSimple;

        event EventHandler CancelReceptionRequest;

        event EventHandler SaveReceptionRequest;

        void Close();
    }
}
