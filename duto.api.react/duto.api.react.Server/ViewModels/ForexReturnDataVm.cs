﻿using duto.api.react.Server.Models;

namespace duto.api.react.Server.ViewModels
{
    public class ForexReturnDataVm
    {
        //
        public string ticker { get; set; }
        //
        public int queryCount { get; set; }
        //
        public int resultsCount { get; set; }
        //
        public bool adjusted { get; set; }
        //
        public List<ForexCandle> results { get; set; }
        //
        public string status { get; set; }
        //
        public string request_id { get; set; }
        //
        public int count { get; set; }

        public static implicit operator ForexReturnDataVm(string v)
        {
            throw new NotImplementedException();
        }
    }
}
