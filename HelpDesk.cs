using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItServiceCompany
{
    class HelpDesk:Employee
    {
        //properties
        public string Language { get; private set; }
        public string LanguageCertCode { get; private set; }
        public int NumberOfCalls { get; private set; }
        public static int CommissionMultiplier { get; set; }
        //constructor
        public HelpDesk(string name,int birthYear,string language,string langCertcode) : base(name, birthYear)
        {
            this.Language = language;
            this.LanguageCertCode = langCertcode;
        }
        //methods
        public void Callings()
        {
            NumberOfCalls++;
        }
        public override int Income()
        {
            return base.Income()+NumberOfCalls*CommissionMultiplier;
        }
        public override string ToString()
        {
            return base.ToString()+"\n            language knowledge:" +Language;
        }
    }
}
