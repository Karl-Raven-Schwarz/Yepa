

using System;
using System.Collections.ObjectModel;

namespace Yepa.Models{
    public class DataModel {
        public string Icon { get; set; }
        public string TypeData { get; set; }
        public string Data { get; set; }
        public DateTime Date { get; set; }
        public int Key { get; set; }
        public DataModel(){ }
    }

    public class GroupDataModel : ObservableCollection<DataModel>{
        public string Title { get; set; }
    }
}
