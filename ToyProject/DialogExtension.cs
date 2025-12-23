using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Core.Helper;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Presenter;
using ToyProject.View;
using ToyProject.View.Dialog;

namespace ToyProject
{
    public static class DialogExtension
    {
        public static void ShowNewPatientDialog(this IWin32Window parent)
        {
            FormManager.ShowForm
           (
               parent,
               () => new NewPatientDialogForm(),
               (f) => new NewPatientDialogPresenter(f, f.CreateMessageService())
           );
        }

        public static void ShowPatientDetailDialog(this IWin32Window parent, Patient patient)
        {
            FormManager.ShowForm
           (
               parent,
               () => new PatientDetailDialogForm(),
               (f) => new PatientDetailDialogPresenter(f, f.CreateMessageService()),
               (f) => f.LoadView(patient)
           );
        }

        public static void ShowNewReceptionDialog(this IWin32Window parent, Patient patient)
        {
            FormManager.ShowForm
            (
                parent,
                () => new ReceptionDialogForm(),
                (f) => new ReceptionDialogPresenter(f, f.CreateMessageService()),
                (f) => f.LoadNew(patient)
            );
        }

        public static void ShowReceptionDialog(this IWin32Window parent, ReceptionWithPatientSimpleResponse reception)
        {
            FormManager.ShowForm
            (
                parent,
                () => new ReceptionDialogForm(),
                (f) => new ReceptionDialogPresenter(f, f.CreateMessageService()),
                (f) => f.LoadReception(reception)
            );
        }

        public static Test ShowCreateTestDialog(this IWin32Window parent, Test test = null)
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

        public static void ShowNewPatientReceptionDialog(this IWin32Window parent)
        {
            FormManager.ShowForm
           (
               parent,
               () => new NewPatientReceptionDialogForm(),
               (f) => new NewPatientReceptionDialogPresenter(f, f.CreateMessageService())
           );
        }

        public static Equipment ShowEquipmentManagementDialog(this IWin32Window parent, Equipment item)
        {
            var form = new EquipmentManagementDialogForm(item);
            var owner = (parent as Form) ?? (parent as Control)?.FindForm();
            form.Owner = owner;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(owner);

            return form.GetResult();
        }
    }

    public static class FormManager
    {
        public static f ShowForm<f, p>(IWin32Window parent, Func<f> createForm, Func<f, p> createPresenter, Action<f> Load = null, bool attachOwner = false)
            where f : Form
            where p : PresenterBase
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
            var presetner = createPresenter?.Invoke(form);
            var owner = (parent as Form) ?? (parent as Control)?.FindForm();
            form.Owner = owner;
            form.TopMost = false;
            
            if (owner != null)
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Shown += (_, __) =>
                {
                    var targetX = owner.Location.X + (owner.Width - form.Width) / 2;
                    var targetY = owner.Location.Y + (owner.Height - form.Height) / 2;
                    form.Location = new Point(targetX, targetY);
                };
                Load?.Invoke(form);
                form.Show(owner);
            }

            if (attachOwner == false)
                form.Owner = null;

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
            var owner = (parent as Form) ?? (parent as Control)?.FindForm();
            form.Owner = owner;
            form.StartPosition = FormStartPosition.CenterParent;
            Load?.Invoke(form);
            form.ShowDialog(owner);
            return form;
        }
    }
}
