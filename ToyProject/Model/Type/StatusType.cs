namespace ToyProject.Model.Type
{
    public enum StatusType
    {
        Reception,
        Progress,
        Complete
    }

    public static class StatusTypeExtension
    {
        public static string ToDisplayText(this StatusType self)
        {
            switch (self)
            {
                case StatusType.Reception:
                    return "접수";

                case StatusType.Progress:
                    return "진행중";

                case StatusType.Complete:
                    return "완료";
            }

            return string.Empty;
        }

        public static StatusType ToStatusType(this string self)
        {
            if (self == StatusType.Reception.ToString())
                return StatusType.Reception;

            if (self == StatusType.Progress.ToString())
                return StatusType.Progress;

            if (self == StatusType.Complete.ToString())
                return StatusType.Complete;

            return StatusType.Reception;
        }
    }
}
