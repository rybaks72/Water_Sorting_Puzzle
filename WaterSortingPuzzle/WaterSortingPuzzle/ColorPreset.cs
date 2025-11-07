using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionMaster
{
    internal class ColorPreset
    {
        public Color Background { get; set; }
        public Color Text { get; set; }
        public Color Button { get; set; }

        public ColorPreset(Color background, Color button, Color text)
        {
            Background = background;
            Text = text;
            Button = button;
        }
    }
}
