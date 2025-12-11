using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyProject.Core.Helper;
using ToyProject.Presenter;
using ToyProject.View.Dialog;

namespace ToyProject
{
    public static class DialogExtension
    {
        public static void ShowNewPatientDialog(IWin32Window parent)
        {
            if (DialogHelper.IsFormOpen<NewPatientDialogForm>())
            {
                var existingForm = Application.OpenForms.OfType<NewPatientDialogForm>().FirstOrDefault();
                existingForm.BringToFront();
                existingForm.Activate();
                return;
            }

            var form = new NewPatientDialogForm();
            new NewPatientDialogPresenter(form);
            form.Show(parent);
        }
    }

    public static class FormManager
    {


        public static void ShowDialog<f, p>(Func<f> createForm, Func<f, p> createPresenter)
            where f : Form
        {
            if (DialogHelper.IsFormOpen<f>())
            {
                var existingForm = Application.OpenForms.OfType<f>().FirstOrDefault();
                existingForm.BringToFront();
                existingForm.Activate();
            }

            var form = createForm();
            var presetner = createPresenter(form);
            form.Show();
        }
    }
}
