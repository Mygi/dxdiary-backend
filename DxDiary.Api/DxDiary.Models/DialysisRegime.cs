using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxDiary.Models
{
    public class Dose
    {
        public string? UnitsOfMeasure { get; set; }
        public double Dosage { get; set; }

        public string? ScheduleTimeFrame { get; set; }
        public double DosesPerTrimeFrame { get; set; }
    }
    public class DialysisRegime
    {
        public long RegimeId { get; set; }

        public Guid UserId { get; set; }

        public int BloodFlow { get; set; }

        public int DialysateFlow { get; set; }

        public double Hours { get; set; }

        public double KPlus { get; set; }

        public double NaPlus { get; set; }

        public double CaTwoPlus { get; set; }

        public double Temperature { get; set; }

        public double Glucose { get; set; }

        public double Bicarbonate { get; set; }

        public string? DialyserModel { get; set; }

        public string? NeedleSize { get; set; }

        public string? AccessType { get; set; }

        public string? Anticoagulant {get;set;}
        public int? AnticoagulantStopTime { get; set; }

        public Dose? InitialAnticoagulantDose { get; set; }
        public string? AnticoagInit { get; set; }

        public Dose? HourlyAnticoagulantDose { get; set; }
        public string? AnticoagHourly{ get; set; }

    }
}
