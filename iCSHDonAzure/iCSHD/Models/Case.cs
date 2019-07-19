using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iCSHD.Models
{
    public class Case
    {
        private Guid caseID;
        private long caseNumber;
        private int caseAge;
        private int idleTime;
        private int severity;
        private string slaState;
        //private string serviceLevel;
        private float currentSentiScore;
        private float historySentiScore;
        private int historyCxEmailCounts;
        private int fDRstate;
        private int labor;
        private Boolean isResolved; 

        public Case(Guid caseID, long caseNumber, int caseAge, int idleTime, int severity, string slaState, float currentSentiScore, float historySentiScore, int historyCxEmailCounts, int fDRstate, int labor, Boolean isResolved)

        {
            this.caseID = caseID;
            this.caseNumber = caseNumber;
            this.caseAge = caseAge;
            this.idleTime = idleTime;
            this.severity = severity;
            this.slaState = slaState;
            //this.serviceLevel = serviceLevel;
            this.currentSentiScore = currentSentiScore;
            this.historyCxEmailCounts = historyCxEmailCounts;
            this.historySentiScore = historySentiScore;
            this.fDRstate = fDRstate;
            this.labor = labor;
            this.isResolved = isResolved;
        }


        public Guid CaseID
        {
            get { return caseID; }
            set { caseID = value; }
        }

        public long CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        public int CaseAge
        {
            get { return caseAge; }
            set { caseAge = value; }
        }
 
        public int IdleTime
        {
            get { return idleTime; }
            set { idleTime = value; }
        }

        public int Severity
        {
            get { return severity; }
            set { severity = value; }
        }

        private string SlaState
        {
            get { return slaState; }
            set { slaState = value; }
        }
            
    //    public string ServiceLevel
     //  {
      //     get { return serviceLevel; }
      //      set { serviceLevel = value; }
     //   }

        public float CurrentSentiScore
        {
            get { return currentSentiScore; }
            set { currentSentiScore = value; }
        }

        public float HistorySentiScore
        {
            get { return historySentiScore; }
            set { historySentiScore = value; }
        }

        public int HistoryCxEmailCounts
        {
            get { return historyCxEmailCounts; }
            set { historyCxEmailCounts = value; }
        }

        public int FDRState
        {
            get { return fDRstate; }
            set { fDRstate = value; }
        }


        public int Labor
        {
            get { return labor; }
            set { labor = value; }
        }

        public Boolean IsResolved
        {
            get { return isResolved; }
            set { isResolved = value; }
        }

    }
}