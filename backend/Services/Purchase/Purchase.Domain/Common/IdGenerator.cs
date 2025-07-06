namespace Purchase.Domain.Common
{
    public static class IdGenerator
    {
        private static readonly long Epoch = new DateTime(2020, 1, 1).Ticks;
        private static long _lastTimestamp = -1L;
        private static long _sequence = 0L;
        private static readonly object LockObject = new();

        public static long GenerateId()
        {
            lock (LockObject)
            {
                long timestamp = (DateTime.UtcNow.Ticks - Epoch) / TimeSpan.TicksPerMinute;

                if (timestamp == _lastTimestamp)
                {
                    _sequence++;
                }
                else
                {
                    _sequence = 0L;
                    _lastTimestamp = timestamp;
                }

                return (timestamp << 22) | (_sequence);
            }
        }
    }
}
