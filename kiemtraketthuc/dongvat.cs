using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace kiemtraketthuc
{
    class dongvat
    {
        public dongvat() { }
        public dongvat(string name)
        {

            this.name = name;

        }

        private string name;
        public string dongvatName
        {
            get { return name; }
            set { name = value; }
        }
        private string maulong;
        public string dongvatmaulong
        {
            get { return maulong; }
            set { maulong = value; }
        }

        public virtual void Talk()
        {
            if (dongvatName.Equals("Gâu gâu") && (dongvatmaulong.Equals("đen")))
                MessageBox.Show(this.dongvatName + " tôi là chó lông " + this.dongvatmaulong);
            else if (dongvatName.Equals("Meo meo") && (dongvatmaulong.Equals("trắng")))
                MessageBox.Show(this.dongvatName + " tôi là mèo lông " + this.dongvatmaulong);
        }
    }
}