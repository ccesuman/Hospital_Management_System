using HealthcareDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareBLL
{
    public class State
    {
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public int CountryCode { get; set; }
        public List<State> GetState()
        {
            List<State> stateListbll = new List<State>();
            StateInfo stateinfo = new StateInfo();
            List<StateInfo> stateinfoList = stateinfo.GetStateInfo();
            foreach (StateInfo item in stateinfoList)
            {
                State state = new State();
                state.StateCode = item.StateCode;
                state.StateName = item.StateName;
                state.CountryCode = item.CountryCode;
                stateListbll.Add(state);
            }
            return stateListbll;
        }
    }
}
