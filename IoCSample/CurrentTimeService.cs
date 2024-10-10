namespace IoCSample
{
    public class CurrentTimeService : ITimeService
    {
        private DateTime now = DateTime.Now;

        public string ShowTime()
        {
            return $"{now.Hour}:{now.Minute}:{now.Second}";
        }
    }
}
