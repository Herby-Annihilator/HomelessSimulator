using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HomelessModel.Common
{
    public class Icon
    {
        public Image ResourseIcon { get; set; }
        public Icon(Image yourIcon)
        {
            ResourseIcon = yourIcon;
        }
    }
}
