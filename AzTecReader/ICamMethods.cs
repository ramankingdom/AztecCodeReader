using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzTecReader
{
    public interface ICamMethods
    {
        void Start();
        void Stop();
        Bitmap GetBitmap();
    }
}
