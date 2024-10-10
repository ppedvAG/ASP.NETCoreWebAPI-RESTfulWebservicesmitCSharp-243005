namespace IoCSample
{
    public class UniversalTimeService : ITimeService
    {
        private DateTime now = DateTime.Now;

        public string ShowTime()
        {
            var time = DateTime.Now.ToUniversalTime();
            return $"Universal Time: {time}";
        }
    }
}
