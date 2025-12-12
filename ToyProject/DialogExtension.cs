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
            form.Owner = parent as Form;
            new NewPatientDialogPresenter(form);
            form.Show(parent);
        }

        public static void ShowNewReceptionDialog(IWin32Window parent, Patient patient)
        {
            FormManager.ShowForm
            (
                parent,
                () => new ReceptionDialogForm(),
                (f) => new ReceptionDialogPresenter(f, f.CreateMessageService()),
                (f) => f.LoadNew(patient)
            );
        }

        public static void ShowReceptionDialog(IWin32Window parent, ReceptionWithPatientSimpleResponse reception)
        {
            FormManager.ShowForm
            (
                parent,
                () => new ReceptionDialogForm(),
                (f) => new ReceptionDialogPresenter(f, f.CreateMessageService()),
                (f) => f.LoadReception(reception)
            );
        }

        public static Test ShowCreateTestDialog(IWin32Window parent, Test test = null)
        {
            var form = FormManager.ShowDialogForm
            (
                parent,
                () => new CreateTestDialogForm(),
                (f) => new CreateTestDialogPresenter(f, f.CreateMessageService()),
                (f) => f.LoadView(test)
            );

            return form.IsOk ? form.GetResult() : null;
        }
    }

    public static class FormManager
    {
        public static f ShowForm<f, p>(IWin32Window parent, Func<f> createForm, Func<f, p> createPresenter, Action<f> Load = null)
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
            form.Owner = parent as Form;
            Load?.Invoke(form);
            form.Show(parent);
            return form;
        }


        public static f ShowDialogForm<f, p>(IWin32Window parent, Func<f> createForm, Func<f, p> createPresenter, Action<f> Load = null)
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
            form.Owner = parent as Form;
            Load?.Invoke(form);
            form.ShowDialog(parent);
            return form;
        }
    }
}
