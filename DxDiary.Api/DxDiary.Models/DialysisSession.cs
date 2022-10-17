namespace DxDiary.Models
{
    public class DialysisSession
    {
        public long SessionId { get; set; }

        public Guid UserId { get; set; }

        public long RegimeId { get; set; }

        public DateTime StartDate { get; set; }
        public int BloodFlow { get; set; }

        public int DialysateFlow { get; set; }

        public double Hours { get; set; }

        public double BloodVolume { get; set; }

        public double AverageTransMembranePressure { get; set; }

        public double AverageVenousPressure { get; set; }

        public double AverageArterialPressure { get; set; }

        public double SystolicPre { get; set; }

        public double SystolicPost { get; set; }

        public double DiastolicPre { get; set; }

        public double DiastolicPost { get; set; }

        public double Temperature { get; set; }

    }
}