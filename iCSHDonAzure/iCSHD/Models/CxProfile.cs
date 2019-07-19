using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iCSHD.Models
{
    public class CxProfile
    {
        private Guid cxID;
        private string cxName;
        private string cxEmail;
        private Double recentCPE;
        private string country;
        private string companyName;
        private Double surveylikelyhood;

        public CxProfile(Guid cxID,string cxName, string cxEmail, Double recentCPE, string country, string companyName, Double surveylikelyhood)

        {
            this.cxID = cxID;
            this.cxName = cxName;
            this.cxEmail = cxEmail;
            this.recentCPE = recentCPE;
            this.country = country;
            this.companyName = companyName;
            this.surveylikelyhood = surveylikelyhood;

         }


        public CxProfile(string cxName, Double recentCPE, string country, string companyName)

        {
            this.cxName = cxName;
            this.recentCPE = recentCPE;
            this.country = country;
            this.companyName = companyName;

        }


        public string CxName
        {
            get { return cxName; }
            set { cxName = value; }
        }

        public string CxEmail
        {
            get { return cxEmail; }
            set { cxEmail = value; }
        }

        public Double RecentCPE
        {
            get { return recentCPE; }
            set { recentCPE = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public Double Surveylikelyhood
        {
            get { return surveylikelyhood; }
            set { surveylikelyhood = value; }
        }

        public Guid CxID
        {
            get { return cxID; }
            set { cxID = value; }
        }


    }
}