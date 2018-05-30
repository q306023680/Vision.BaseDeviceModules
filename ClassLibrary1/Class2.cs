using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PropertyTools.DataAnnotations;

namespace 属性事件保存
{
    [Serializable]
    public class Class2: System.ComponentModel.INotifyPropertyChanged
    {
#pragma warning disable 67

        [field: NonSerialized]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

#pragma warning restore 67
        protected void RaisePropertyChanged(string property)
        {
            Debug.WriteLine("Model.RaisePropertyChanged on " + property);

            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(property));
        }

        public int DD
        {
            get; set;
        } = 100;
        int mCHH;

        [Slidable(0,255)]
        [Spinnable(0,255)]
        public int CHH
        {
            get
            {
               
                return mCHH;
            }
            set
            {
                mCHH = value;
                RaisePropertyChanged("Data");
                RaisePropertyChanged("CHH");
            }
        }

        public string Data
        {
            get
            {
                return CHH.ToString();
            }
        }
    }
}
