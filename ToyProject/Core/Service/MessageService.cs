using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ToyProject.Core.Service
{
    public class MessageService
    {
        private readonly IWin32Window _owner;

        public MessageService(IWin32Window owner)
        {
            _owner = owner;
        }

        public void ShowInfo(string message)
        {
            XtraMessageBox.Show(_owner, message, "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            XtraMessageBox.Show(_owner, message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Confirm(string message)
        {
            var result = XtraMessageBox.Show(_owner, message, "확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result == DialogResult.OK;
        }
    }

}
