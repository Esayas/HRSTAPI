using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRSTAPI.Models
{
    public class HrstDetail
    {
        [Key]
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public DateTime ScreenedDate { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Mrn { get; set; } = "";
        public int Age { get; set; }
        public int Sex { get; set; }
        public int KnownHIVPositive { get; set; }
        public int PatientOnART { get; set; }
        public int BehavioralRisk { get; set; }
        //public int BehavioralRiskType { get; set; }
        public bool UnprotectedSex { get; set; }
        public bool PartnerofKnownHIVPositive { get; set; }
        public bool MultipleSexualPartners { get; set; }
        public bool SexWithNonRegularPartner { get; set; }
        public bool ExchangedSexForMoney  { get; set; }
        public bool SexualPracticeUnderInfluence { get; set; }
        public bool NeedleSharingforInjection { get; set; }
        public bool HistoryofSexualViolence { get; set; }
        public bool STIHistory { get; set; }
        public bool OtherBehavioralRiks { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BehavioralRiskOther { get; set; } = "";
        public int ClinicalSign { get; set; }
        //public int ClinicalSignType { get; set; }
        public bool PersistentGeneralizedLymphadenopathy { get; set; }
        public bool UnexplainedWeightLoss { get; set; }
        public bool UnexplainedPersistentHepatosplenomegaly { get; set; }
        public bool UnexplainedChronicDiarrhea { get; set; }
        public bool RecurrentRespiratoryTractInfections { get; set; }
        public bool RecurrentSevereBacterialInfections { get; set; }
        public bool OralUlceration { get; set; }
        public bool EsophagealCandidiasis { get; set; }
        public bool SkinRelatedProblem { get; set; }
        public bool STI { get; set; }
        public bool HerpesZoster { get; set; }
        public bool KaposiSarcoma { get; set; }
        public bool PCP { get; set; }
        public bool PresumptiveTBConfirmedTB { get; set; }
        public bool CMVInfections { get; set; }
        public bool CNSRelatedInfectionsLymphoma { get; set; }
        public bool CervicalCarcinoma { get; set; }
        public bool Leishmaniosis { get; set; }
        public bool UnexplainedPersistentFever { get; set; }
        public bool OtherSign { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ClinicalSignOther { get; set; } = "";


        //public int PatientGroup { get; set; }
        public bool WomenEngagedCommercialSex { get; set; }
        public bool SexualPartnerPLHIV { get; set; }
        public bool DivorcedWidowWidower { get; set; }
        public bool PWID { get; set; }
        public bool Prisoners { get; set; }
        public bool LongDistanceDriver { get; set; }
        public bool WorkersHotSpotArea { get; set; }
        public bool HighRiskAdolescentGirlYoungWomen { get; set; }
        public bool OtherPatientGroup { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string PatientGroupOther { get; set; } = "";

        public int EligibleForTesting { get; set; }
        public int ReceivedHIVTestSameDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ReceivedHIVTestSameDateOther { get; set; } = "";
        [Column(TypeName = "nvarchar(200)")]
        public string Reason { get; set; } = "";
        public int HIVTestResult { get; set; }
        public int EscortedForLinkage { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; } = "";
        public DateTime ModifiedDate { get; set; }


    }
}
