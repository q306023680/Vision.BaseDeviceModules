using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyTools.DataAnnotations;

namespace 属性事件保存
{
    [Serializable]
    public class Class3
    {
        Class1 C;
        [ShowPropertyGrid]
        public Class1 C1
        {
            get
            {
                if (C == null)
                    C = new Class1();
                return C;
            }
            set
            {
                C = value;
            }
        }
    }
}
