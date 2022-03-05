using System.Collections.Generic;

namespace Yepa.Models
{
    public class NotificationModel
    {
        public class Data
        {
            public string foo { get; set; }
            public Data() { }
            public Data(string _foo) 
            {
                foo = _foo;
            }
        }

        public class Contents
        {
            public string en { get; set; }
            public string es { get; set; }
            public Contents() { }
            public Contents(string _en, string _es) 
            {
                en = _en;
                es = _es;
            }
        }

        public class Root
        {
            public string app_id { get; set; }
            public List<string> include_external_user_ids { get; set; }
            public string channel_for_external_user_ids { get; set; }
            public Data data { get; set; }
            public Contents contents { get; set; }
            public string small_icon { get; set; }
        }
    }
}
