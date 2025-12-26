using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ToyProject.Core.Validation;

namespace ToyProject.View.Helper
{
    public static class ErrorProviderHelper
    {
        public static void ShowErrors(ErrorProvider errorProvider, IDictionary<string, Control> fieldMap, ValidationResult validationResult)
        {
            errorProvider.Clear();

            if (validationResult == null || validationResult.IsValid || fieldMap == null)
                return;

            foreach (var kv in validationResult.Errors)
            {
                if (fieldMap.TryGetValue(kv.Key, out var control))
                    errorProvider.SetError(control, kv.Value);
            }
        }

        public static void HookClearOnChange(IEnumerable<Control> controls, ErrorProvider errorProvider)
        {
            if (controls == null)
                return;

            foreach (var control in controls.Where(c => c != null))
            {
                if (control is BaseEdit editor)
                    editor.EditValueChanged += (s, e) => errorProvider.SetError((Control)s, string.Empty);
                else
                    control.TextChanged += (s, e) => errorProvider.SetError((Control)s, string.Empty);
            }
        }
    }
}
