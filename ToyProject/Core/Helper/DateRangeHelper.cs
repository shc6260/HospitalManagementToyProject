using DevExpress.XtraEditors.Controls;
using System;

namespace ToyProject.Core.Helper
{
    public static class DateRangeHelper
    {
        public static DateRange ToDayRange()
        {
            return new DateRange(DateTime.Today, DateTime.Today);
        }
    }
}
