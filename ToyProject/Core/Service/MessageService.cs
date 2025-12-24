using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyProject.View.Dialog;

namespace ToyProject.Core.Service
{
    public class MessageService
    {
        private readonly IWin32Window _owner;

        public MessageService(IWin32Window owner)
        {
            _owner = owner;
        }

        private SplashScreenManager _splash;



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


        public async Task RunInProgressAsync(Func<Task> task)
        {
            var owner = _owner as Form;
            if (owner == null)
                await task();

            IOverlaySplashScreenHandle handle = null;

            try
            {
                var workTask = task();
                var delayTask = Task.Delay(300);

                if (await Task.WhenAny(workTask, delayTask) == delayTask)
                    handle = SplashScreenManager.ShowOverlayForm(owner);

                await workTask;
            }
            catch (Exception e)
            {
                if (handle != null)
                    SplashScreenManager.CloseOverlayForm(handle);

                ShowError(e.Message);
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (handle != null)
                    SplashScreenManager.CloseOverlayForm(handle);
            }
        }


        public async Task RunInProgressPopupAsync(Func<Task> task)
        {
            var owner = _owner as Form;
            if (owner == null)
                await task();

            try
            {
                _splash = _splash ?? new SplashScreenManager(owner, typeof(ProgessPopup), useFadeIn: true, useFadeOut: true);

                var workTask = task();
                var delayTask = Task.Delay(300);

                if (await Task.WhenAny(workTask, delayTask) == delayTask)
                {
                    owner.Enabled = false;
                    _splash.ShowWaitForm();
                }

                await workTask;
            }
            catch (Exception e)
            {
                if (_splash?.IsSplashFormVisible == true)
                    _splash.CloseWaitForm();
                ShowError(e.Message);
                Console.WriteLine(e.ToString());
            }
            finally
            {
                owner.Enabled = true;
                if (_splash?.IsSplashFormVisible == true)
                    _splash.CloseWaitForm();
            }
        }


        public async Task RunInTryCatchAsync(Func<Task> task)
        {
            try
            {
                await task();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
                Console.WriteLine(e.ToString());
            }
        }
    }

    public static class MessageServiceExtension
    {
        public static MessageService CreateMessageService(this IWin32Window window)
        {
            return new MessageService(window);
        }
    }

}
