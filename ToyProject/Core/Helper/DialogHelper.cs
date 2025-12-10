using System.Linq;
using System.Windows.Forms;

namespace ToyProject.Core.Helper
{
    public class DialogHelper
    {
        public static bool IsFormOpen<T>() where T : Form
        {
            return Application.OpenForms.OfType<T>().Any();
        }
    }
}
