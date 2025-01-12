using System;
using System.Collections.Generic;
using System.Text;

namespace Yepa.Interfaces{

    public interface IPhoneNumberService{
        string GetSimCountryIso();
        string GetNetworkCountryIso();
    }
}
