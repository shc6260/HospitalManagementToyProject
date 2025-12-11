using System;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Core.Helper;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Presenter;
using ToyProject.View.Dialog;

namespace ToyProject
{
    public static class DialogExtension
    {
        public static void ShowNewPatientDialog(IWin32Window parent)
        {
            if (DialogHelper.IsFormOpen<NewPatientDialogForm>())
                return;

            var form = new NewPatientDialogForm();
            new NewPatientDialogPresenter(form);
            form.Show(parent);
        }

        public static void ShowReceptionDialog(IWin32Window parent, Patient patient)
        {
            FormManager.DialogShow
            (
                parent,
                () => new ReceptionDialogForm(),
                (f) => new ReceptionDialogPresenter(f, f.CreateMessageService()),
                (f) => f.LoadView(patient)
            );
        }
    }

    public static class FormManager
    {


        public static f DialogShow<f, p>(IWin32Window parent, Func<f> createForm, Func<f, p> createPresenter, Action<f> Load = null)
            where f : Form
        {
            if (DialogHelper.IsFormOpen<f>())
            {
                var existingForm = Application.OpenForms.OfType<f>().FirstOrDefault();
                existingForm.BringToFront();
                existingForm.Activate();
                Load?.Invoke(existingForm);

                return existingForm;
            }

            var form = createForm();
            var presetner = createPresenter(form);
            Load?.Invoke(form);
            form.Show(parent);

            return form;
        }
    }
}
