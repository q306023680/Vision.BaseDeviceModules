using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using PropertyTools.DataAnnotations;
namespace 属性事件保存
{
    [Serializable]
    public class Class1: System.ComponentModel.INotifyPropertyChanged
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

        public string Name
        {
            get;
            set;
        }
        Class2 c;
        [ShowPropertyGrid]
        public Class2 C
        {
            get
            {if (c == null)
                    c = new Class2();
                return c;
            }
            set
            {
                c = value;
            }
        }
    }
}
